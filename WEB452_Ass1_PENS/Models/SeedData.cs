using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WEB452_Ass1_PENS.Data;
using System;
using System.Linq;

namespace WEB452_Ass1_PENS.Models {
    public static class SeedData {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new PenderMifflinContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PenderMifflinContext>>())) {
                // Look for any movies.
                if (context.Pen.Any()) {
                    return;   // DB has been seeded
                }

                context.Pen.AddRange(
                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Black",
                        Size = "Heavy Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Heavy Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = true
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Blue",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Blue",
                        Size = "Medium Tip",
                        Erasable = true
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = true
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Silver",
                        Price = 4.99M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Gold",
                        Price = 4.99M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Black",
                        Price = 4.99M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Refillable Fountain Pen",
                        Price = 3.49M,
                        Type = "Fountain",
                        Colour = "Exchangeable",
                        Size = "Fine Tip",
                        Erasable = false
                    },

                    new Pen {
                        Name = "PMI Refillable Fountain Pen",
                        Price = 3.49M,
                        Type = "Fountain",
                        Colour = "Exchangeable",
                        Size = "Medium Tip",
                        Erasable = false
                    }


                );
                context.SaveChanges();
            }
        }
    }
}