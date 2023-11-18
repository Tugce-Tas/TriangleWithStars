namespace Triangle;

public class TriangleStars
{
    public void Stars() {
    
        Console.Write("Sayı girin: ");
        int n = Convert.ToInt16(Console.ReadLine());
    
        for (int i=1; i<=n ; i++) 
        { 
            for (int j=1; j<=(n-i) ; j++) 
            {
                Console.Write(" ");
            }
            for (int k=1; k<=(2*i-1) ; k++) 
            {
                Console.Write("*");
            }
        
            Console.WriteLine();
        }
    }
}

