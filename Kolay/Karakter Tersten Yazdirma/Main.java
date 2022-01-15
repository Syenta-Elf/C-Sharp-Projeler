import java.util.Scanner;

/**
 * Main
 */
public class Main {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        reverse(sc.nextLine());
        sc.close();
        
    }

    public static void reverse(String str)
    {
        StringBuffer reverseStr = new StringBuffer(str);
        reverseStr.reverse();
        System.out.println(reverseStr);
    }
    
}