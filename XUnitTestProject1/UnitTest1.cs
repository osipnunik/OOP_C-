using ConsoleApp12_13.task13;
using System;
using System.Text;
using Xunit;
using XUnitTestProject1.task12;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HandBookLinqService service = new HandBookLinqService();
            service.CreateXmlFile();    //���������� ���� �������
            service.ShowAll();  //����� ���� �������

            Handbook expectedCompany = new Handbook();
            expectedCompany.Name = "CocaCola";
            expectedCompany.Owner = "Obama";
            expectedCompany.Phone = "095784361";
            expectedCompany.Address = "Alaska";
            expectedCompany.Activity = "drinks";
            Console.WriteLine("aaaaaaaaaaaaaaaaaa");
            Assert.Equal(expectedCompany, service.SearchByName("CocaCola"));  //�� ��������
            Assert.Equal(expectedCompany, service.SearchByOwner("Obama"));      //�� ���������
            Assert.Equal(expectedCompany, service.SearchByPhone("095784361"));  //�� ������ ��������
            Assert.Equal(expectedCompany, service.SearchByActivity("drinks"));  //�� ������������

            Handbook company = new Handbook();
            company.Name = "Bmw";
            company.Owner = "Gans Christian Andersen";
            company.Phone = "98472948724";
            company.Address = "Berlin";
            company.Activity = "Autoes";
            service.AddCompany(company);   //pposibility of writing another
            Assert.Equal(company, service.SearchByName("Bmw"));
        }
        [Fact]
        public void TestWorldCreation()
        {
            LifeAbscence lifeAbscence = new LifeAbscence();
            lifeAbscence.WorldCreation();
            Assert.True(lifeAbscence.Grass.Count > 0);
            Assert.True(lifeAbscence.Rabits.Count > 0);
            Assert.True(lifeAbscence.Rabits.Count > 0);
        }
        [Fact]
        public void Test()
        {

        }


    }
}
