using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AutoMapper;
using Flora.Api.Controllers;
using Flora.Api.Dtos;
using Flora.Api.Interfaces;
using Flora.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace Flora.Tests.UnitTests
{
    public class MaterialControllerTests
    {
        [Fact]
        public async Task GetMaterialsTest()
        {
            var mockRepo = new Mock<IFloraRepository>();
            var mockMapper = new Mock<IMapper>();

            mockMapper.Setup(m => m.Map<IEnumerable<MaterialDTO>>(It.IsAny<IEnumerable<Material>>()))
                .Returns((IEnumerable<Material> source) => GetTestMapping(source));
            mockRepo.Setup(repo => repo.GetMaterials()).Returns(Task.FromResult((IEnumerable<Material>)GetTestMaterials()));

            var controller = new MaterialController(mockRepo.Object, mockMapper.Object);


            var result = await controller.GetMaterials();

            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);

            var model = okObjectResult.Value as IEnumerable<MaterialDTO>;
            Assert.NotNull(model);
            Assert.Single(model);
        }

        private List<Material> GetTestMaterials()
        {
            List<Material> testMaterials = new List<Material>();

            testMaterials.Add(new Material { MaterialId = 1, Name = "Gül" });

            return testMaterials;
        }

        private List<MaterialDTO> GetTestMapping (IEnumerable<Material> input)
        {
            List<MaterialDTO> testMaterials = new List<MaterialDTO>();

            foreach(var item in input)
            {
                testMaterials.Add( new MaterialDTO {
                    Name = item.Name
                });
            }

            return testMaterials;
        }
    }
}