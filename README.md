# How to Build a Card Carousel UI in .NET MAUI

This demo shows how to build a card carousel UI in the .NET MAUI SfCarousel control.

This section explains how to create a rich card-style carousel that displays a collection of travel destinations using the .NET MAUI SfCarousel control. The carousel is bound to a collection of places and renders each item as a structured card with an image, rating badge, title, location, description, price, and a call-to-action button, making it ideal for showcasing destinations, products, or featured content in your application.

The SfCarousel control is data-driven, so the cards displayed in the carousel are generated dynamically from the bound collection. This approach helps create flexible, data-driven, and visually rich user interfaces while keeping the UI implementation clean and maintainable.

In this example, the carousel loads a collection of popular destinations (such as the Eiffel Tower, Venice Canal, Santorini, Maldives Beach, and Swiss Alps) and renders them as swipeable cards. Each card combines a top image area with a rating badge and a details section containing the title, country, short description, starting price, and an "Explore" button, all wrapped in a rounded card with a drop shadow for a modern look.

## Key Highlights

- Displays a swipeable card carousel using the SfCarousel control.
- Renders each item as a structured card with image, rating badge, and details.
- Uses data binding to populate the carousel from an ObservableCollection.
- Supports a custom DataTemplate to fully control the visual layout of each item.
- Includes a rating badge, price label, and call-to-action button inside each card.
- Applies rounded corners and a drop shadow for a modern card-style appearance.
- Built on the MVVM pattern for a clean separation of data and UI.

By following the implementation steps, you can easily customize the appearance of each card and create rich browsing or shopping experiences based on your application data.
