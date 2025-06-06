using ClinicLab.Application.Models;
using ClinicLab.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicLab.Application.BusinessLogic
{
    public class TestService
    {
        private readonly TestRepository repo = new();

        public List<TestType> GetAllTestTypes() => repo.GetAllTestTypes();

        public void AddTestType(TestType testType) => repo.AddTestType(testType);

        public void UpdateTestType(TestType testType) => repo.UpdateTestType(testType);

        public void DeleteTestType(int id) => repo.DeleteTestType(id);

        public void AddTestOrder(TestOrder order) => repo.AddTestOrder(order);

        public List<TestOrder> GetAllTestOrders() => repo.GetAllTestOrders();

        public void UploadResult(int orderId, string filePath) =>
            repo.UploadResult(orderId, filePath);
    }
}
