using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing3
{
    /// <summary>
    /// Summary description for tstStockCollection
    /// </summary>
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.SneakerNo = 1;
            TestItem.SneakerName = "Air Jordan 1";
            TestItem.Price = 100;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);

        }


        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.Available = true;
            TestStock.SneakerNo = 1;
            TestStock.SneakerName = "Air Jordan 1";
            TestStock.Price = 999;
            TestStock.DateAdded = DateTime.Now.Date; //Convert.ToDateTime("04/02/2022")

            AllStock.ThisStock = TestStock;
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.SneakerNo = 1;
            TestItem.SneakerName = "Air Jordan 1";
            TestItem.Price = 100;
            TestItem.DateAdded = DateTime.Now.Date;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.SneakerNo = 1;
            TestItem.SneakerName = "Air Jordan 1 Mid";
            TestItem.Price = 100;
            TestItem.DateAdded = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();

            TestItem.SneakerNo = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.SneakerNo = 1;
            TestItem.SneakerName = "Air Jordan 1 Mid";
            TestItem.Price = 100;
            TestItem.DateAdded = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();

            TestItem.SneakerNo = PrimaryKey;

            TestItem.Available = false;
            TestItem.SneakerNo = 2;
            TestItem.SneakerName = "Air Jordan 1 Hight";
            TestItem.Price = 500;
            TestItem.DateAdded = DateTime.Now.Date;
            AllStock.ThisStock = TestItem;
            AllStock.Update();
            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.SneakerNo = 1;
            TestItem.SneakerName = "Air Max";
            TestItem.Price = 100;
            TestItem.DateAdded = DateTime.Now.Date;

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();

            TestItem.SneakerNo = PrimaryKey;

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportBySneakerNameOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();

            FilteredStock.ReportBySneakerName("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);

         }

        [TestMethod]
        public void ReportBySneakerNameNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();

            FilteredStock.ReportBySneakerName("random sneaker");
            Assert.AreEqual(0, FilteredStock.Count);

        }

        [TestMethod]
        public void ReportBySneakerNameTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportBySneakerName("Nike Air Jordan 1");
            if(FilteredStock.Count == 2)
            {
                if(FilteredStock.StockList[0].SneakerNo != 1)
                {
                    OK = false;
                }
                if(FilteredStock.StockList[1].SneakerNo != 15)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
