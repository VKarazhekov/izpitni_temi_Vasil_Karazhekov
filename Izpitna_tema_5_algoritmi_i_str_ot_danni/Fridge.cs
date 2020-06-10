using System;
using System.Linq;

namespace Izpitna_tema_5_algoritmi_i_str_ot_danni
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public void AddProduct(string ProductName)
        {
            Product newProduct = new Product(ProductName);
            if (count == 0)
            {
                head = newProduct;
                tail = newProduct;
                count++;
            }
            else
            {
                tail.Next_product = newProduct;
                tail = newProduct;
                count++;
            }
        }
        public string[] CookMeal(int start, int end)
        {
            Product tempProduct = head;
            Console.Write("Meal cooked. Used Products: ");
            if (end > count)
            {
                for (int i = 0; i < count; i++)
                {
                    if(i>=start)
                    {
                        if (i == count - 1)
                        {
                            Console.Write($"{tempProduct.ToString()}\n");
                            return null;
                        }
                        Console.Write($"{tempProduct.ToString()}, ");
                    }
                    tempProduct = tempProduct.Next_product;
                }
            }
            else
            {
                for (int i = 0; i < end; i++)
                {
                    if (i>=start)
                    {
                        if (i == end - 1)
                        {
                            Console.Write($"{tempProduct.ToString()}\n");
                            return null;
                        }
                        Console.Write($"{tempProduct.ToString()}, ");
                    }
                    tempProduct = tempProduct.Next_product;
                }
            }
            return null;
        }
        public string RemoveProductByIndex(int index)
        {
            Product tempProduct = head;
            if (index >= count || index<0) return null;
            if (index == 0)
            {
                Console.WriteLine($"Removed: {tempProduct.ToString()}");
                head = head.Next_product;
                count--;
                return null;
            }
            if (index == count - 1)
            {
                Console.WriteLine($"Removed: {tail.ToString()}");
                for (int i = 0; i < count; i++)
                {
                    if (i == count - 2)
                    {
                        tail = tempProduct;
                        tail.Next_product = null;
                        count--;
                        return null;
                    }
                    tempProduct = tempProduct.Next_product;
                }
            }
            for (int i = 0; i < count; i++)
            {
                if(i == index-1)
                {
                    Console.WriteLine($"Removed: {tempProduct.Next_product.ToString()}");
                    tempProduct.Next_product = tempProduct.Next_product.Next_product;
                    count--;
                    i++;
                    return null;
                }
                tempProduct = tempProduct.Next_product;
            }
            return null;
        }
        public string RemoveProductByName(string name)
        {
            Product tempProduct = head;
            for (int i = 0; i < count; i++)
            {
                if (tempProduct.ToString()==name)
                {
                    RemoveProductByIndex(i);
                    return null;
                }
                tempProduct = tempProduct.Next_product;
            }
            return null;
        }
        public bool CheckProductIsInStock(string name)
        {
            Product tempProduct = head;
            for (int i = 0; i < count; i++)
            {
                if(tempProduct.ToString()==name)
                {
                    Console.WriteLine("Product is in stock.");
                    return true;
                }
                tempProduct = tempProduct.Next_product;
            }
            Console.WriteLine("Not in stock.");
            return false;
        }
        public string[] ProvideInformationAboutAllProducts()
        {
            Product tempProduct = head;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Product {tempProduct.ToString()}");
                tempProduct = tempProduct.Next_product;
            }
            return null;
        }
    }
}