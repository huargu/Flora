using System.Collections.Generic;
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
    public class BouquetControllerTests
    {
        [Fact]
        public async Task GetBouquetsTest()
        {
            var mockRepo = new Mock<IFloraRepository>();
            var mockMapper = new Mock<IMapper>();

            mockMapper.Setup(m => m.Map<IEnumerable<BouquetDTO>>(It.IsAny<IEnumerable<Bouquet>>()))
                .Returns((IEnumerable<Bouquet> source) => GetTestMapping(source));
            mockRepo.Setup(repo => repo.GetBouquets()).Returns(Task.FromResult((IEnumerable<Bouquet>)GetTestBouquets()));

            var controller = new BouquetController(mockRepo.Object, mockMapper.Object);


            var result = await controller.GetBouquets();

            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);

            var model = okObjectResult.Value as IEnumerable<BouquetDTO>;
            Assert.NotNull(model);
            Assert.Single(model);
        }


        private List<Bouquet> GetTestBouquets()
        {
            List<Bouquet> testBouquets = new List<Bouquet>();

            testBouquets.Add(new Bouquet { BouquetId = 1, Name = "Gül Bahçesi" });

            return testBouquets;
        }
        private List<BouquetDTO> GetTestMapping (IEnumerable<Bouquet> input)
        {
            List<BouquetDTO> testBouquets = new List<BouquetDTO>();

            foreach(var item in input)
            {
                List<BouquetDetailDTO> details = new List<BouquetDetailDTO>();
                if (item.BouquetTypes != null)
                {
                foreach(var detail in item.BouquetTypes)
                {
                    List<ArrangementDTO> arrangments = new List<ArrangementDTO>();

                    if(detail.Materials != null)
                    {
                        foreach(var arg in detail.Materials)
                        {
                            arrangments.Add( new ArrangementDTO {
                                MaterialCount = arg.MaterialCount,
                                Material = new MaterialDTO { Name = arg.Material.Name }
                            });
                        }
                    }
                    details.Add(new BouquetDetailDTO {
                        Size = detail.Size,
                        Price = detail.Price,
                        Materials = arrangments
                    });
                }
                }
                testBouquets.Add( new BouquetDTO {
                    Name = item.Name,
                    BouquetTypes = details
                });
            }

            return testBouquets;
        }
    }
}