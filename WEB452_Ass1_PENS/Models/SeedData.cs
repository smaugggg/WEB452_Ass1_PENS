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
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-closeup.jpg"
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-closeup.jpg"
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Black",
                        Size = "Heavy Tip",
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-closeup.jpg"
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Fine Tip",
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-red.jpg"
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-red.jpg"
                    },

                    new Pen {
                        Name = "PMI Fadeproof Felt Tip Pen",
                        Price = 2.49M,
                        Type = "Felt Tip",
                        Colour = "Red",
                        Size = "Heavy Tip",
                        Erasable = false,
                        Image = "~/images/product/fadeproof-felttip-red.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Black",
                        Size = "Medium Tip",
                        Erasable = true,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Blue",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Blue",
                        Size = "Medium Tip",
                        Erasable = true,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = true,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Ballpoint",
                        Price = 1.09M,
                        Type = "Ballpoint",
                        Colour = "Red",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/ballpoint.jpg"
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Silver",
                        Price = 125.00M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false,
                        Image = "~/images/product/rollerball-silver.jpg"
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Gold",
                        Price = 125.00M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false,
                        Image = "~/images/product/rollerball-gold.jpg"
                    },

                    new Pen {
                        Name = "PMI Luxury Rollerball Black",
                        Price = 125.00M,
                        Type = "Rollerball",
                        Colour = "Black",
                        Size = "Fine Tip",
                        Erasable = false,
                        Image = "~/images/product/rollerball-black.jpg"
                    },

                    new Pen {
                        Name = "PMI Refillable Fountain Pen",
                        Price = 64.99M,
                        Type = "Fountain",
                        Colour = "Exchangeable",
                        Size = "Fine Tip",
                        Erasable = false,
                        Image = "~/images/product/fountainpen.jpg"
                    },

                    new Pen {
                        Name = "PMI Refillable Fountain Pen",
                        Price = 64.99M,
                        Type = "Fountain",
                        Colour = "Exchangeable",
                        Size = "Medium Tip",
                        Erasable = false,
                        Image = "~/images/product/fountainpen.jpg"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}