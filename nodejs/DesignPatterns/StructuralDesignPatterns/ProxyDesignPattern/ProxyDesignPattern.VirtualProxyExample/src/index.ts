// ============================================================================
// VIRTUAL PROXY DESIGN PATTERN
// ============================================================================
// Virtual Proxy delays the creation of an expensive object until it is needed.
//
// Pattern Structure:
//   - IImage: Subject interface
//   - HighResolutionImage: RealSubject (expensive to create)
//   - ImageProxy: Proxy (creates RealSubject only when needed)
// ============================================================================

import { IImage } from "./IImage";
import { ImageProxy } from "./ImageProxy";

async function main() {
  console.log("=== VIRTUAL PROXY PATTERN DEMO ===\n");

  // Create proxies for 3 images (no real images loaded yet!)
  console.log("--- Creating image proxies (instant) ---\n");

  const image1: IImage = new ImageProxy("photo1.png");
  const image2: IImage = new ImageProxy("photo2.png");
  const image3: IImage = new ImageProxy("photo3.png");

  console.log("\n--- All proxies created. No images loaded yet! ---\n");

  // Only image2 will be loaded now
  console.log("--- Displaying image 2 (triggers loading) ---\n");
  await image2.display();

  console.log("\n--- Displaying image 2 again (already loaded) ---\n");
  await image2.display();

  console.log("\n--- Checking which images are loaded ---\n");
  console.log(`Image 1: ${(image1 as ImageProxy).isLoaded ? "LOADED" : "NOT LOADED"}`);
  console.log(`Image 2: ${(image2 as ImageProxy).isLoaded ? "LOADED" : "NOT LOADED"}`);
  console.log(`Image 3: ${(image3 as ImageProxy).isLoaded ? "LOADED" : "NOT LOADED"}`);

  console.log("\n=== SUMMARY ===");
  console.log("Only image 2 was loaded because only it was displayed.");
  console.log("Images 1 and 3 remain unloaded - saving resources!");
}

main();
