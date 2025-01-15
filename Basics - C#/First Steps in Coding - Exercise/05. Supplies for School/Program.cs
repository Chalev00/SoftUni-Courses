double penPack = 5.80;
double markerPack = 7.20;
double cleaner = 1.20;

int penPackAmount = int.Parse(Console.ReadLine());
int markerPackAmount = int.Parse(Console.ReadLine());
int cleanerAmount = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double allPen = penPack * penPackAmount;
double allMarker = markerPack * markerPackAmount;
double allCleaner = cleanerAmount * cleaner;


double allMaterials = allPen + allMarker + allCleaner;

double realDiscount = (double)discount / 100;

double finalPrice = allMaterials - (allMaterials * realDiscount);

Console.WriteLine(finalPrice);
