// See https://aka.ms/new-console-template for more information
using Hayvanat_Bahcesi_Yonetimi;

// Hayvanlar:
// Atlar(atlar, zebralar, eşekler vb.),
// Kedigiller(kaplanlar, aslanlar vb.),
// Kemirgenler(sıçanlar, kunduzlar vb.) gibi gruplardaki türlerle karakterize edilir.
// Hayvanlar hakkında depolanan bilgilerin çoğu tüm gruplamalar için aynıdır.
// tür adı, ağırlığı, yaşı vb.
// Sistem ayrıca her hayvan için belirli ilaçların dozajını alabilmeli => getDosage ()
// Sistem Yem verme zamanlarını hesaplayabilmelidir => getFeedSchedule ()

Atlar atlar = new Atlar();
atlar.atyaz();
atlar.getDosage("a", 8);
Kedigiller kedigiller = new Kedigiller();
kedigiller.kediyaz();
kedigiller.getDosage("b", 4);
Kemirgenler kemirgenler = new Kemirgenler();
kemirgenler.kemirgenyaz();
kemirgenler.getDosage("c",7);