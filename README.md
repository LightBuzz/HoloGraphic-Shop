# Holographic Shop

The Holographic Shop allows customers to browse a collection of products in Mixed Reality. The customers can view products, interact with them, position them in the 3D space, and even create a virtual Cart. The application consists of a Unity client app and a Microsoft Azure backend.

# Unity - HoloLens

The Unity client application downloads the data from the server, renders the holograms, and allows for interaction.

## Dependencies

* [Unity 5.6.1f1](https://unity3d.com/unity/whats-new/unity-5.6.1)
* [HoloToolkit for Unity 5.6.1f1](https://github.com/Microsoft/HoloToolkit-Unity/releases/tag/v1.5.7.0)

## Scenes

### Shop
Displays the categories of the products in a holographic list.

### Category
Displays the products of the selected category in a holographic list.

### Product
Displays the details of the selected product (title, price, descriptions) and two buttons:

* Add to Cart
* Interact

### Cart
Displays the products that have been added to the Cart, using the "Add to Cart" button.

### Interaction
Allows the customer to interact with a Hologram and place it in the 3D space. The scene is using Spatial Mapping and allows the customer to place a product on the detected surfaces (wall, floor, etc). Additionally, this screen offers hologram-specific capabilities. Examples:

* Place a TV on a wall and watch a video.
* Place a desk on the floor and move nearby.
* Place a Stereo on a desk and turn on the music.

# Microsoft Azure

The Microsoft Azure backend infrastructure includes the data and the HTTPS web API endpoints.

More information to be added soon.
