﻿using System.Text.Json;
using Bogus;
using ContactEFAPI.Data;
using ContactEFAPI.Models;
using DatabasePopulationMethods;
using Microsoft.EntityFrameworkCore;

//Pulling some sample data from Bogus examples

var testLocation = new Faker<Location>()
    .RuleFor(l => l.Name, f => f.Company.CompanyName() + " " + f.Company.CompanySuffix())
    .RuleFor(l => l.Address, f => f.Address.StreetAddress())
    .RuleFor(l => l.City, f => f.Address.City())
    .RuleFor(l => l.State, f => f.Address.State())
    .RuleFor(l => l.PostalCode, f => f.Address.ZipCode())
    .RuleFor(l => l.Latitude, f => f.Address.Latitude())
    .RuleFor(l => l.Longitude, f => f.Address.Longitude());

var contactId = 1;
var testContact = new Faker<Contact>()
    .RuleFor(c => c.FirstName, f => f.Name.FirstName())
    .RuleFor(c => c.MiddleName, f => f.Name.FirstName())
    .RuleFor(c => c.LastName, f => f.Name.LastName())
    .RuleFor(c => c.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
    .RuleFor(c => c.EmailDescription, f => f.Name.JobTitle())
    .RuleFor(c => c.Phone, f => f.Phone.PhoneNumber())
    .RuleFor(c => c.PhoneDescription, f => f.Lorem.Sentence())
    //.RuleFor(c => c.Location, f => testLocation.Generate())
    .RuleFor(c => c.Notes, f => f.Lorem.Paragraphs(2))
    ;

var testDepartment = new Faker<Department>()
    .RuleFor(d => d.Name, f => f.Commerce.Department())
    .RuleFor(d => d.Code, (f, d) => d.Name[..f.Random.Number(2, 3)].ToUpper())
    //.RuleFor(d => d.Primary, f => testContact.Generate())
    //.RuleFor(d => d.Location, f => testLocation.Generate())
    .RuleFor(d => d.LocationId, f => 5)
    .RuleFor(d => d.Description, f => f.Hacker.IngVerb() + " " + f.Hacker.Adjective() + " " + f.Hacker.Noun());

using ContactManagementContext test = new();
ExtensionsForTesting.DatabaseMagic<Location>.Initialize(test, testLocation, test.Locations);

//    test.Contacts.AddRange(testContact.Generate(2));
//    test.SaveChanges();

//test.Departments.AddRange(testDepartment.Generate(4));
//test.SaveChanges();

//var user = testDepartment.Generate(3);

//user.OutputConsole();

//Console.WriteLine(JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true }));
namespace DatabasePopulationMethods
{
    public static class ExtensionsForTesting
    {
        public static void OutputConsole(this object obj)
        {
            Console.WriteLine(JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                WriteIndented = true
            }));
        }
        //public class DatabaseMagic<T>
        //{     
        //public static void Initialize(ContactManagementContext context, Faker fakerModel, DbSet database)
        //{
        //    database.AddRange(fakerModel.Generate(3));
        //    context.SaveChanges();
        //}
        //}
        //public static void Initialize(DbSet<T> dbSet, Faker<T> fakerModel, ContactManagementContext context)
        //{
        //    dbSet.AddRange(fakerModel.Generate(3));
        //    context.SaveChanges();
        //}
    }
}