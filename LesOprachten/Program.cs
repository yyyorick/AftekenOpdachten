public class Program {
    public static void Main() {
        int[,] distances = new int[,] {
            { 0, 50, 135, 120, 65, 65 },  // Arnhem
            { 50, 0, 140, 75, 20, 70 },   // Amersfoort
            { 135, 140, 0, 220, 170, 75 },// Assen
            { 120, 75, 220, 0, 55, 145 }, // Rotterdam
            { 65, 20, 170, 55, 0, 90 },   // Utrecht
            { 65, 70, 75, 145, 90, 0 }    // Zwolle
        };

        string[] cities = { "Arnhem", "Amersfoort", "Assen", "Rotterdam", "Utrecht", "Zwolle" };
        int studentsPerCity = 5;
        
        int minDistance = int.MaxValue;
        string bestCity = "";

        for (int i = 0; i < distances.GetLength(0); i++) {
            int totalDistance = 0;
            for (int j = 0; j < distances.GetLength(1); j++) {
                if (i != j) {
                    totalDistance += distances[i, j] * studentsPerCity;
                }
            }
            if (totalDistance < minDistance) {
                minDistance = totalDistance;
                bestCity = cities[i];
            }
            Console.WriteLine($"Totale afstand voor {cities[i]}: {totalDistance} km");
        }
        Console.WriteLine($"\nDe beste stad voor bijles is: {bestCity} met een totale reisafstand van {minDistance} km.");
    }
    public void WeekTweeOpdrachtEen(Dictionary<string, int[]> dictionary){
        
    }
}