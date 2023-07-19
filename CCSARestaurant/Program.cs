// See https://aka.ms/new-console-template for more information
using CCSARestaurant.Core;
using CCSARestaurant.DB;

Console.WriteLine("Hello, World!");

// Establish Database Connection
var sessionFactory = new SessionFactory();
var session = sessionFactory.Session;


//Perform CRUD Operations

//Create
var customer = new Customer { FirstName = "Kachi", Surname = "Wachikwu" };
session.Save(customer);
sessionFactory.Commit(session);


//Read
var customer1 = session.Get(typeof(Customer), 1);
sessionFactory.Commit(session);


//Update
session.Update(customer);
sessionFactory.Commit(session);


//Delete
session.Delete(customer);
sessionFactory.Commit(session);



Console.WriteLine("Done!");

