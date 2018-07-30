using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmirFeder.Models
{
    //Class responsbile for adding initial data to database
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();

            if (!context.Products.Any() && !context.Services.Any())
            {
                context.AddRange(
                    new Product
                    {
                        Name = "Blachy z otworami okrągłymi",
                        Description = "Blachy z otworami okrągłymi, średnice otworów 0,5 - 100mm, grubości blach 0,4 - 16,0mm.",
                        Category = "Blachy perforowane"//,
                    //    SubCategory = "Blachy"

                    },
                                        new Product
                                        {
                                            Name = "Otwory okrągłe w układzie 60°",
                                            Description = "",
                                            Category = "Blachy z otworami okrągłymi"

                                        },
                                        new Product
                                        {
                                            Name = "Otwory okrągłe w układzie prostym",
                                            Description = "",
                                            Category = "Blachy z otworami okrągłymi"

                                        },
                                        new Product
                                        {
                                            Name = "Otwory okrągłe w układzie 45°",
                                            Description = "",
                                            Category = "Blachy z otworami okrągłymi"

                                        },
                    new Product
                    {
                        Name = "Blachy z otworami kwadratowymi",
                        Description = "Blachy z otworami kwadratowymi, rozmiary otworów 3,0 - 120mm, grubości blach 0,4 - 16,0mm.",
                        Category = "Blachy perforowane"//,
                       // SubCategory = "Blachy"

                    },
                                        new Product
                                        {
                                            Name = "Otwory kwadratowe w układzie prostym",
                                            Description = "",
                                            Category = "Blachy z otworami kwadratowymi"

                                        },
                                        new Product
                                        {
                                            Name = "Otwory kwadratowe w układzie mijanym",
                                            Description = "",
                                            Category = "Blachy z otworami kwadratowymi"

                                        },
                                        new Product
                                        {
                                            Name = "Otwory kwadratowe w układzie 45°",
                                            Description = "",
                                            Category = "Blachy z otworami kwadratowymi"

                                        },
                    new Product
                    {
                        Name = "Blachy z otworami podłużnymi",
                        Description = "Blachy z otworami podłużnymi, szerokości otworów 1,0 - 25mm, grubości blach 0,4 - 16,0mm.",
                        Category = "Blachy perforowane"//,
                        //SubCategory = "Blachy"

                    },
                                        new Product
                                        {
                                            Name = "Otwory podłużne w układzie mijanym",
                                            Description = "",
                                            Category = "Blachy z otworami podłużnymi"
                                        },
                                        new Product
                                        {
                                            Name = "Otwory podłużne w układzie prostym",
                                            Description = "",
                                            Category = "Blachy z otworami podłużnymi"

                                        },
                                        new Product
                                        {
                                            Name = "Otwory podłużne w układzie prostym",
                                            Description = "",
                                            Category = "Blachy z otworami podłużnymi"

                                        },
                    new Product
                    {
                        Name = "Inne",
                        Description = "Pozostałe: wzory dekoracyjne, sita tarkowe, blachy przetłaczane, otwory miseczkowe, przetłaczane, daszkowe, łuskowe, stożkowe, \"jodełkowe\", wzory nietypowe wg specyfikacji Klienta.",
                        Category = "Blachy perforowane"//,
                       // SubCategory = "Blachy"

                    },
                    new Product
                    {
                        Name = "Siatki plecione",
                        Description = "Siatki plecione, z drutów stalowych, ocynkowanych, kwasoodpornych, sprężynowych, żaroodpornych, miedzianych. Wielkość prześwitu oczek 2,0 - 100mm, maksymalna szerokość 2000mm. Stosowane w ogrodzeniach, przesiewaczach, filtrach, obudowach, osłonach.",
                        Category = "Siatki"
                    },
                    new Product
                    {
                        Name = "Siatki zgrzewane",
                        Description = "Siatki zgrzewane, z drutów stalowych, ocynkowanych, kwasoodpornych, o średnicach 2,0 - 14,0mm. Wielkość prześwitu oczek 20,0 - 200mm. Maksymalna szerokość 2000mm. ",
                        Category = "Siatki"
                    },
                    new Product
                    {
                        Name = "Siatki cięto-ciągnione",
                        Description = "Siatki cięto-ciągnione, z blach stalowych, ocynkowanych, kwasoodpornych, aluminiowych, z innych metali kolorowych, o grubościach 0,3 - 6,0mm. Długość oczek 2,0 - 100mm, szerokość oczek 1,5 - 50mm. Siatki w arkuszach, w zwojach, lub docięte na żądany wymiar. Stosowane na elewacjach, w osłonach krat, ogrodzeniach, przesiewaczach, filtrach, obudowach.",
                        Category = "Siatki"
                    },
                    new Product
                    {
                        Name = "Tkaniny metalowe",
                        Description = "Tkaniny metalowe, z drutów zwykłych, ocynkowanych, nierdzewnych, kwasoodpornych, miedzianych, mosiężnych, fosforo-brązowych, z tworzyw sztucznych, o średnicach 0,03 - 2,0mm i prześwicie oczek od 0,04mm. Stosowane w filtrach, sitach, przesłonach, osłonach, moskitierach, dekoracjach.",
                        Category = "Siatki"
                    },
                    new Product
                    {
                        Name = "Inne",
                        Description = "Inne: siatki transporterowe, siatki Rabitza, Izola, Leduchowskiego, siatki dializerowe, siatki leśne, sita szczelinowe, kraty wciskane.",
                        Category = "Siatki"
                    },
                    new Product
                    {
                        Name = "Sprężyny naciskowe",
                        Description = "Sprężyny naciskowe, z drutów okrągłych o średnicy 0,2 - 48,0mm, lub z drutów prostokątnych (przekroje do uzgodnienia).",
                        Category = "Sprężyny"
                    },
                    new Product
                    {
                        Name = "Sprężyny naciągowe",
                        Description = "Sprężyny naciągowe, z drutów okrągłych o średnicy 0,2 - 13,0mm.",
                        Category = "Sprężyny"
                    },
                    new Product
                    {
                        Name = "Sprężyny skrętne",
                        Description = "Sprężyny skrętne, z drutów okrągłych o średnicy 0,4 - 10,0mm, lub z drutów prostokątnych (przekroje do uzgodnienia).",
                        Category = "Sprężyny"
                    },
                    new Product
                    {
                        Name = "Inne",
                        Description = "Pozostałe: sprężyny ślimakowe, sprężyny talerzowe, sprężyny z taśm i płaskowników (grubości 0,1 - 2,5mm), spirale kanalizacyjne, sprężyny faliste, pancerze ochronne, elementy sprężyste z drutu i z blachy sprężynowej wg specyfikacji Klienta.",
                        Category = "Sprężyny"
                    },
                    new Product
                    {
                        Name = "Dennice koszykowe",
                        Description = "Dennice koszykowe wg DIN 28013, w zakresie średnic 15-2800mm, grubość ścian 3-20mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice toroidalne",
                        Description = "Dennice toroidalne wg DIN 28011, w zakresie średnic 15-2800mm, grubość ścian 2-20mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice elipsoidalne PN-64/M-35411",
                        Description = "Dennice elipsoidalne wg PN-64/M-35411, w zakresie średnic 15-508mm, grubość ścian 3-12mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice elipsoidalne PN-75/M-35412,",
                        Description = "Dennice elipsoidalne wg PN-75/M-35412, w zakresie średnic 600-2800mm, grubość ścian 3-20mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice o małej wypukłości",
                        Description = "Dennice o małej wypukłości wg PN-69/M-35413, w zakresie średnic 1300-1400mm, grubość ścian 4-5mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice płaskie",
                        Description = "Dennice płaskie wg PN-69/M-35414, w zakresie średnic 20-2800mm, grubość ścian 2-20mm.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Czasze kuliste",
                        Description = "Czasze kuliste, w zakresie średnic 600-1800mm, grubość ścian do uzgodnienia.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice talerzowe",
                        Description = "Dennice talerzowe, średnice do uzgodnienia, grubość ścian do uzgodnienia.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice dyfuzyjne",
                        Description = "Dennice dyfuzyjne, średnice do uzgodnienia, grubość ścian do uzgodnienia.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Dennice półkuliste",
                        Description = "Dennice półkuliste, średnice do uzgodnienia, grubość ścian do uzgodnienia.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Inne",
                        Description = "Pozostałe: dennice stożkowe, dennice zaślepiające, dennice nietypowe i ponadwymiarowe, kształtki, zwężki, elementy tłoczone wg specyfikacji Klienta.",
                        Category = "Dennice"
                    },
                    new Product
                    {
                        Name = "Stal nierdzewna",
                        Description = "Stal nierdzewna to wspólna nazwa dla dużej rodziny gatunków stali jakościowych, które ze względu na zawartość chromu, wynoszącą przynajmniej 11%, są odporne na niszczenie pod wpływem chemicznej lub elektrochemicznej reakcji z otaczającym środowiskiem",
                        Category = "Stal nierdzewna"
                    }
                    );

                context.Services.AddRange(
                    new Service
                    {
                        Name = "Gięcie",
                        Descripstion = "Oferujemy gięcie blach z wykorzystaniem numerycznych krawędziarek (CNC) o sile nacisku do 220 ton, maksymalnej grubości giętej blachy 20 mm oraz długości gięcia aż do 6000 mm. Posiadane przez nas narzędzia oraz doświadczenie pozwalają na wykonanie również bardzo skomplikowanych i nietypowych gięć i walcowań.",
                    },
                    new Service
                    {
                        Name = "Spawanie TIG",
                        Descripstion = "Spawanie metodą TIG (Tungsten Inert Gas) pozwala na otrzymywanie najwyższej jakości spoin w stalach niestopowych i niskostopowych, nierdzewnych oraz w takich materiałach jak aluminium, miedź i tytan.",
                    },
                    new Service
                    {
                        Name = "Spawanie MIG/MAG",
                        Descripstion = "Spawanie półautomatyczne metodami MIG (Metal Inert Gas) i MAG (Metal Active Gas) jest najczęściej stosowane w procesach spawalniczych. Główne źródła popularności tych procesów to wysoka wydajność spawania, poprawa środowiska pracy spawacza oraz łatwość automatyzacji.",
                    },
                    new Service
                    {
                        Name = "Spawanie łukowe ręczne",
                        Descripstion = "Spawanie łukowe ręczne elektrodą otuloną to proces, w którym trwałe spojenie uzyskuje się przez stopienie ciepłem łuku elektrycznego topliwej elektrody otulonej oraz materiału spawanego.",
                    },
                    new Service
                    {
                        Name = "Wycinanie laserem",
                        Descripstion = "Cięcie laserowe to szybka i bardzo elastyczna technologia wykonywania detali umożliwiająca cięcie i wycinanie dowolnie opracowanych kształtów, a także nacinanie, grawerowanie, znakowanie oraz obróbkę blach powleczonych folią. Jest ona wygodną formą obróbki materiałów ze względu na dużą swobodę projektowania. Metoda ta pozwala na wycinanie elementów blach szlifowanych i polerowanych, bez naruszenia ich powierzchni. Technologię cięcia laserem charakteryzuje bardzo wysoka jakość obróbki, przy jednoczesnej dużej prędkości cięcia, elastyczność zastosowań oraz idealna powtarzalność kształtu, bez względu na wielkość partii produkowanego elementu. Specjalistyczne oprogramowanie urządzenia umożliwia maksymalną optymalizację wykorzystania materiału. Oferujemy Państwu wycinanie laserowe z blach o grubościach: -blacha stalowa stalowa do 25 mm - blacha nierdzewna do 20 mm - aluminium do 12 mm przy wymiarach stołu 2000x4000(6000)mm. Proponujemy wykonywanie kompleksowych usług w zakresie wytwarzania gotowych wyrobów metalowych."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
