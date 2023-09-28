using Microsoft.AspNetCore.Identity;
using MvcAspDotNet.Data;
using MvcAspDotNet.Models;
using System.Diagnostics;
using System.Net;

namespace MvcAspDotNet.Data
{
    public class Seeds
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.UserModels.Any())
                {
                    context.UserModels.AddRange(new List<UserModel>()
                    {
                        new UserModel()
                        {
                            firstname = "Alexander",
                            middlename = "Espanola",
                            lastname = "Novo",
                            username = "alexandernovo123",
                            password = "alexandernovo123"
                         },
                         new UserModel()
                        {
                            firstname = "Char",
                            middlename = "Since",
                            lastname = "500bc",
                            username = "char123",
                            password = "char123"
                         },
                    });
                    context.SaveChanges();
                }
                //Chat
                if (!context.ChatModels.Any())
                {
                    context.ChatModels.AddRange(new List<ChatModel>()
                    {
                        new ChatModel()
                        {
                            sender_id = 1,
                            receiver_id = 2,
                            message = "This is the description of the first race",
                            datetime = DateTime.Now,
                          
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}