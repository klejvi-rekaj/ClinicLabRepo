using ClinicLab.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLab.DataAccess.Repositories
{
    public class TestRepository
    {
        private readonly List<TestType> testTypes = new();
        private readonly List<TestOrder> testOrders = new();

        public TestRepository()
        {
            testTypes.Add(new TestType { Id = 1, Name = "CBC", Price = 50 });
            testOrders.Add(new TestOrder { Id = 1, PatientId = 101, TestTypeId = 1, OrderedDate = DateTime.Now, Status = "Pending" });
        }

        public List<TestType> GetAllTestTypes() => testTypes;

        public void AddTestType(TestType testType) => testTypes.Add(testType);

        public void UpdateTestType(TestType testType)
        {
            var existing = testTypes.FirstOrDefault(t => t.Id == testType.Id);
            if (existing != null)
            {
                existing.Name = testType.Name;
                existing.Price = testType.Price;
            }
        }

        public void DeleteTestType(int id) =>
            testTypes.RemoveAll(t => t.Id == id);

        public void AddTestOrder(TestOrder order) =>
            testOrders.Add(order);

        public List<TestOrder> GetAllTestOrders() => testOrders;

        public void UploadResult(int orderId, string filePath)
        {
            var order = testOrders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                order.ResultFilePath = filePath;
                order.Status = "Completed";
            }
        }
    }
}
