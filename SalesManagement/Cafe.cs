using SalesManagement.DTO;
using SalesManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    public class Cafe
    {
        public string DeleteCategory(int categoryId)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var categories = (from category in db.Categories
                                          where category.CategoryId == categoryId
                                          select category).FirstOrDefault();

                        db.Categories.Remove(categories);
                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string UpdateCategory(int categoryId, string categoryName)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var categories = (from category in db.Categories
                                          where category.CategoryId == categoryId
                                          select category).FirstOrDefault();

                        categories.CategoryName = categoryName;

                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public List<Category> GetAllCategory()
        {
            using (var db = new CafeDatabase())
            {
                return (from category in db.Categories
                        select category).ToList();
            }
        }

        private Category GetCategoryById(int categoryId)
        {
            using (var db = new CafeDatabase())
            {
                return (from cat in db.Categories
                        where cat.CategoryId == categoryId
                        select cat).FirstOrDefault();
            }
        }

        public string AddCategory(string item)
        {
            using (var db = new CafeDatabase())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hasDuplicate = (from cat in db.Categories
                                            where cat.CategoryName == item.Trim()
                                            select cat).FirstOrDefault();

                        if (hasDuplicate != null) return "Duplicate Category.";
                        else
                        {
                            Category category = new Category()
                            {
                                CategoryName = item.Trim()
                            };

                            db.Categories.Add(category);
                            db.SaveChanges();
                            transaction.Commit();
                            return "Passed";
                        }
                    }
                    catch (SqlException error)
                    {
                        // Throw error
                        transaction.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string AddSupplier(Supplier item)
        {
            using (var db = new CafeDatabase())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hasDuplicate = (from sup in db.Suppliers
                                            where sup.CompanyName == item.CompanyName
                                            select sup).FirstOrDefault();

                        if (hasDuplicate != null) return "Duplicate Supplier.";
                        else
                        {
                            db.Suppliers.Add(item);
                            db.SaveChanges();
                            transaction.Commit();
                            return "Passed";
                        }
                    }
                    catch (SqlException error)
                    {
                        // Throw error
                        transaction.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string DeleteSupplier(int supplierId)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var supplier = (from sup in db.Suppliers
                                        where sup.SupplierId == supplierId
                                        select sup).FirstOrDefault();

                        db.Suppliers.Remove(supplier);
                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string UpdateSupplier(Supplier item)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var supplier = (from sup in db.Suppliers
                                          where sup.SupplierId == item.SupplierId
                                          select sup).FirstOrDefault();

                        supplier.Address = item.Address;
                        supplier.CompanyName = item.CompanyName;
                        supplier.ContactNumber = item.ContactNumber;
                        supplier.ContactPerson = item.ContactPerson;
                        supplier.Landline = item.Landline;

                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public List<Supplier> GetSuppliers()
        {
            using (var db = new CafeDatabase())
            {
                return (from sup in db.Suppliers
                        select sup).ToList();
            }
        }

        private Supplier GetSupplierById(int supplierId)
        {
            using (var db = new CafeDatabase())
            {
                return (from sup in db.Suppliers
                        where sup.SupplierId == supplierId
                        select sup).FirstOrDefault();
            }
        }

        public string AddProduct(Product item)
        {
            using (var db = new CafeDatabase())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var hasDuplicate = (from prod in db.Products
                                            where prod.ProductName == item.ProductName
                                            select prod).FirstOrDefault();

                        if (hasDuplicate != null) return "Duplicate Product.";
                        else
                        {
                            db.Products.Add(item);
                            db.SaveChanges();
                            transaction.Commit();
                            return "Passed";
                        }
                    }
                    catch (SqlException error)
                    {
                        // Throw error
                        transaction.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string DeleteProduct(int productId)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var supplier = (from prod in db.Products
                                        where prod.ProductId == productId
                                        select prod).FirstOrDefault();

                        db.Products.Remove(supplier);
                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public string UpdateProduct(Product item)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var product = (from prod in db.Products
                                        where prod.ProductId == item.ProductId
                                        select prod).FirstOrDefault();

                        product.Description = item.Description;
                        product.ProductName = item.ProductName;
                        product.ProductPrice = item.ProductPrice;
                        //product.Stocks = item.Stocks;
                        product.Description = item.Description;


                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (SqlException error)
                    {
                        trans.Rollback();
                        return error.Message;
                    }
                }
            }
        }

        public List<ProductDTO> GetProducts()
        {
            using (var db = new CafeDatabase())
            {
                List<ProductDTO> productDTOs = new List<ProductDTO>();
                var products =  (from prod in db.Products
                                select prod).ToList();

                if (products.Count > 0)
                {
                    foreach (var product in products)
                    {
                        ProductDTO productDTO = new ProductDTO()
                        {
                            ProductId = product.ProductId,
                            Category = GetCategoryById(product.CategoryId).CategoryName,
                            Stocks = product.Quantity,
                            Supplier = GetSupplierById(product.SupplierId).CompanyName,
                            Description = product.Description,
                            Price = product.ProductPrice,
                            Product = product.ProductName
                        };
                        productDTOs.Add(productDTO);
                    }
                    return productDTOs;
                }
                else return null;
            }
        }

        public string Hash(string username, string password)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {

                    var userCheck = (from usr in db.Users
                                     where usr.Username == username
                                     select usr).FirstOrDefault();

                    if (userCheck != null)
                    {
                        return username + " is already taken. Please think of another user name.";
                    }
                    else
                    {
                        try
                        {
                            User user = new User()
                            {
                                Password = Password.Hash(password, "0123456789"),
                                Username = username
                            };

                            db.Users.Add(user);
                            db.SaveChanges();
                            trans.Commit();
                            return "Passed";
                        }
                        catch (Exception error)
                        {
                            trans.Rollback();
                            return error.Message;
                            throw;
                        }
                    }
                }
            }
        }


        public string VerifyAccount(string username, string password)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    var userName = (from user in db.Users
                                    where user.Username.ToLower() == username.ToLower()
                                    select user).FirstOrDefault();

                    if (userName != null)
                    {
                        var passwordVerified = Password.Verify(password, userName.Password, "0123456789");

                        if (passwordVerified) return "Passed";
                        else return "Password is incorrect.";
                    }
                    else return "User Name is incorrect.";
                }
            }
        }

        public string UpdateUser(string newUsername, string newPassword, int userId)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var currentUser = (from user in db.Users
                                           where user.UserId == userId
                                           select user).FirstOrDefault();
                        if (currentUser != null)
                        {
                            currentUser.Username = newUsername;
                            currentUser.Password = Password.Hash(newPassword, "0123456789");

                            db.SaveChanges();
                            trans.Commit();
                            return "Passed";
                        }
                        else return "No user detected!";
                    }
                    catch (Exception error)
                    {
                        trans.Rollback();
                        return error.Message;
                        throw;
                    }
                }
            }
        }

        public string DeleteUser(int userId)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        var currentUser = (from user in db.Users
                                           where user.UserId == userId
                                           select user).FirstOrDefault();
                        if (currentUser != null)
                        {
                            db.Users.Remove(currentUser);
                            db.SaveChanges();
                            trans.Commit();
                            return "Passed";
                        }
                        else return "No user detected!";
                    }
                    catch (Exception error)
                    {
                        trans.Rollback();
                        return error.Message;
                        throw;
                    }
                }
            }
        }


        public List<User> GetUsers()
        {
            using (var db = new CafeDatabase())
            {
                return (from user in db.Users
                        select user).ToList();
            }
        }

        public Product GetProductById(int productId)
        {
            using (var db = new CafeDatabase())
            {
                return (from prod in db.Products
                        where prod.ProductId == productId
                        select prod).FirstOrDefault();
            }
        }

        public User GetUserById(int userId)
        {
            using (var db = new CafeDatabase())
            {
                return (from user in db.Users
                        where user.UserId == userId
                        select user).FirstOrDefault();
            }
        }

        public int GetUserIdByName(string name)
        {
            using (var db = new CafeDatabase())
            {
                return (from user in db.Users
                        where user.Username.ToLower() == name.ToLower()
                        select user).FirstOrDefault().UserId;
            }
        }


        public Dictionary<string, List<TransactionDTO>> GetTransactionsByRecNo()
        {
            using (var db = new CafeDatabase())
            {
                List<TransactionDTO> transactionDTOs;
                Dictionary<string, List<TransactionDTO>> transactionPerRecNo = new Dictionary<string, List<TransactionDTO>>();

                var groupTransactions = (from tran in db.Transactions
                                    group tran by tran.ReceiptNumber into groupTrans
                                    select groupTrans);

                if (groupTransactions.Count() > 0)
                {
                    foreach (var transactions in groupTransactions)
                    {
                        transactionDTOs = new List<TransactionDTO>();
                        foreach (var transaction in transactions)
                        {
                            TransactionDTO transactionDTO = new TransactionDTO()
                            {
                                TransactionId = transaction.TransactionId,
                                Price = GetProductById(transaction.ProductId).ProductPrice,
                                ProductName = GetProductById(transaction.ProductId).ProductName,
                                Quantity = transaction.Quantity,
                                TransactionDate = transaction.TransactionDate,
                                Username = GetUserById(transaction.UserId).Username,
                                ReceiptNumber = transactions.Key
                            };
                            transactionDTOs.Add(transactionDTO);
                        }
                        transactionPerRecNo.Add(transactions.Key, transactionDTOs);
                    }
                    return transactionPerRecNo;
                }
                else return null;
            }
        }


        public List<TransactionDTO> GetTransactions()
        {
            using (var db = new CafeDatabase())
            {
                List<TransactionDTO> transactionDTOs = new List<TransactionDTO>();

                var transactions = (from tran in db.Transactions
                                    select tran).ToList();

                if (transactions.Count > 0)
                {
                    foreach (var transaction in transactions)
                    {
                        TransactionDTO transactionDTO = new TransactionDTO()
                        {
                            TransactionId = transaction.TransactionId,
                            Price = GetProductById(transaction.ProductId).ProductPrice,
                            ProductName = GetProductById(transaction.ProductId).ProductName,
                            Quantity = transaction.Quantity,
                            TransactionDate = transaction.TransactionDate,
                            Username = GetUserById(transaction.UserId).Username,
                            ReceiptNumber = transaction.ReceiptNumber
                        };
                        transactionDTOs.Add(transactionDTO);
                    }
                }
                return transactionDTOs;
            }
        }

        public string AddTransaction(List<Transaction> items)
        {
            using (var db = new CafeDatabase())
            {
                using (var trans = db.Database.BeginTransaction())
                {
                    try
                    {
                        List<Transaction> transactions = new List<Transaction>();

                        foreach (var item in items)
                        {
                            Transaction transaction = new Transaction()
                            {
                                ProductId = item.ProductId,
                                Quantity = item.Quantity,
                                ReceiptNumber = item.ReceiptNumber,
                                TransactionDate = DateTime.Today,
                                UserId = item.UserId
                            };
                            transactions.Add(transaction);
                        }

                        db.Transactions.AddRange(transactions);
                        db.SaveChanges();
                        trans.Commit();
                        return "Passed";
                    }
                    catch (Exception error)
                    {
                        trans.Rollback();
                        return error.Message;
                        throw;
                    }
                }
            }
        }


    }
}
