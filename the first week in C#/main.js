function addToCart() {
    // Get product information
    var productName = "Product Name";
    var productPrice = 20.00;
    var productImage = "product.jpg";

    // Create an object to represent the product
    var product = {
        name: productName,
        price: productPrice,
        image: productImage
    };

    // Check if cart already exists in local storage
    var cart = JSON.parse(localStorage.getItem("cart")) || [];

    // Add the product to the cart
    cart.push(product);

    // Save the updated cart back to local storage
    localStorage.setItem("cart", JSON.stringify(cart));

    alert("Product added to cart!");
}
