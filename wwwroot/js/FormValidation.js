//Aubrey Farnbach (Wright) Section 2 Group 1
$(function () {
    // Initialize form validation on the registration form.
    $("form[name='NewRestaurant']").validate({
        // Specify validation rules
        rules: {

            Name: {
                required: true,
            },
            RestaurantName: {
                required: true,
            },
            FavoriteDish: {
            },
            RestaurantPhone: {
                phoneUS: true
            },
        },
        // Specify validation error messages
        messages: {

            Name: {
                required: "Please include your name",
            },
            RestaurantName: {
                required: "Please enter the restaurant name",
            },
            FavoriteDish: {
            },
            RestaurantPhone: {
                phoneUS: "Please enter a valid US phone number",
            },
        },

        submitHandler: function (form) {
            form.submit();
        }
    });
});