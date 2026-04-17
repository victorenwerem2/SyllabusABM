public class RandomNumbers {
    public static void main(String[] args) {

        long number = 1234567890L; // 10-digit number

        System.out.println("Starting Number: " + number);

        System.out.println("Numbers in loop (+100 each time):");

        for (int i = 0; i < 10; i++) {
            number = number + 100;
            System.out.println(number);
        }

        System.out.println("Ending Number: " + number);
    }
}