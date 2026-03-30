package structural.proxy.cachingproxy;

public class Main {
    public static void main(String[] args) {
        System.out.println("=== CACHING PROXY PATTERN DEMO (with TTL) ===\n");

        WeatherServiceProxy weatherService = new WeatherServiceProxy(600);
        System.out.println();

        System.out.println("--- Request 1: Istanbul ---\n");
        String result1 = weatherService.getWeather("Istanbul");
        System.out.println("Result: " + result1 + "\n");

        System.out.println("--- Request 2: Istanbul (should be cached) ---\n");
        String result2 = weatherService.getWeather("Istanbul");
        System.out.println("Result: " + result2 + "\n");

        System.out.println("--- Request 3: London ---\n");
        String result3 = weatherService.getWeather("London");
        System.out.println("Result: " + result3 + "\n");

        System.out.println("=== SUMMARY ===");
        System.out.println("Request 1: Cache MISS - fetched from API");
        System.out.println("Request 2: Cache HIT - returned cached data");
        System.out.println("Request 3: Cache MISS - new city, fetched from API");
    }
}
