﻿Console.OutputEncoding = System.Text.Encoding.UTF8; // without this the € character was showed as ?

// Create new product from Product class
Product marmellataArancia = new Product("Marmellata all'arancia",
                                        "La marmellata di arance è una deliziosa conserva di frutta che vi permetterà di portare in tavola un pò d'inverno anche in estate!",
                                        3.99f,
                                        10);

// 8 get digit product code
marmellataArancia.GetProductCode();

// get price with and without vat
marmellataArancia.GetVatPrice();
marmellataArancia.GetNoVatPrice();

// Products array
Product[] products = new Product[6];
products[0] = marmellataArancia;
products[1] = new Product("Biscotti integrali",
                          "Biscotti integrali ricchi in fibre per tanta bontà e un mix perfetto tra equilibrio e piacere",
                           1.59f,
                           10);
products[2] = new Product("Acqua naturale",
                          "Acqua minerale naturale minimamente mineralizzata",
                           0.69f,
                           3);
products[3] = new Product("Banana",
                          "Chiquita Banane Gialle Frutta Fresca Sfusa",
                           1.49f,
                           10);
products[4] = new Product("Maionese",
                          "Classica con Olio di Semi di Girasole, Ideale per Sandwich e Tartine",
                           2.29f,
                           22);
products[5] = new Product("Maionese",
                          "Classica con Olio di Semi di Girasole, Ideale per Sandwich e Tartine",
                           2.29f,
                           22);