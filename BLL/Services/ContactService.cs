using BLL.Dto;
using DAL.DataBase;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContactService
    {
        DataBaseContext context = new DataBaseContext();

        public List<ContactListDto> GetContactList()
        {
            var contact = context.Contacts.Select(p => new ContactListDto
            {
                Id = p.Id,
                FullName = $"{p.FirstName} {p.LastName}",
                PhoneNumber = p.PhoneNumber
            }).ToList();

            return contact;
        }

        public List<ContactListDto> SearchContact(string searchKey)
        {
            var contactQuery = context.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                contactQuery = contactQuery.Where(c => c.FirstName.Contains(searchKey) || c.LastName.Contains(searchKey)
                || c.PhoneNumber.Contains(searchKey) || c.CompanyName.Contains(searchKey)
                );
            }

            var contactList = contactQuery.Select(c => new ContactListDto
            {
                Id = c.Id,
                FullName = $"{c.FirstName} {c.LastName}",
                PhoneNumber = c.PhoneNumber
            }).ToList();

            return contactList;
        }

        public ResultDto DeleteContact(int id)
        {
            var result = context.Contacts.Find(id);

            if (result != null)
            {
                context.Remove(result);
                context.SaveChanges();

                return new ResultDto
                {
                    IsSuccess = true,
                    Message = "مخاطب با موفقیت حذف شد"
                };
            }
            return new ResultDto
            {
                IsSuccess = false,
                Message = "مخاطب یافت نشد"
            };
        }

        public ResultDto<ContactDetailDto> ContactDetail(int id)
        {
            var contact = context.Contacts.Find(id);
            if (contact == null)
            {
                return new ResultDto<ContactDetailDto>
                {
                    Data = null,
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد"
                };
            }

            var data = new ContactDetailDto
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                PhoneNumber = contact.PhoneNumber,
                CreateAt = contact.CreateAt,
                CompanyName = contact.CompanyName,
                Description = contact.Description
            };

            return new ResultDto<ContactDetailDto>
            {
                Data = data,
                IsSuccess = true
            };
        }

        public ResultDto AddNewContact(AddContactDto newContact)
        {
            if (string.IsNullOrEmpty(newContact.PhoneNumber))
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "شماره موبایل اجباری می باشد"
                };
            }

            Contact contact = new Contact
            {
                FirstName = newContact.FirstName,
                LastName = newContact.LastName,
                PhoneNumber = newContact.PhoneNumber,
                CompanyName = newContact.CompanyName,
                Description = newContact.Description,
                CreateAt = DateTime.Now
            };

            context.Contacts.Add(contact);
            context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = $"مخاطب {newContact.FirstName} {newContact.LastName} با موفقیت در دیتابیس ثبت شد"
            };

        }

        public ResultDto EditContact(EditContactDto editContactDto)
        {
            var contact = context.Contacts.Find(editContactDto.Id);
            if (contact == null)
            {
                return new ResultDto
                {
                    IsSuccess = false,
                    Message = "مخاطب یافت نشد"
                };
            }

            contact.FirstName = editContactDto.FirstName;
            contact.LastName = editContactDto.LastName;
            contact.CompanyName = editContactDto.CompanyName;
            contact.PhoneNumber = editContactDto.PhoneNumber;
            contact.Description = editContactDto.Description;

            context.SaveChanges();

            return new ResultDto
            {
                IsSuccess = true,
                Message = "مخاطب با موفقیت ویرایش شد"
            };

        }
    }
}
