

function Car(make, model, year, price, cylinders, pass, type, image, desc, city, high){
    //this.id = id;
    this.make = make;
    this.model = model;
    this.year = year;
    this.DailyPrice = price;
    this.cyls = cylinders;
    this.Passengers = pass;
    this.type = type;
    this.ImageUrl = image;
    this.Description = desc;
    this.MpgCity = city;
    this.MpgHigh = high;
}

function clearForm(){
    $("#txtMake").val("");
    $("#txtMake").focus();
    $("#txtModel").val("");
    $("#txtYear").val("");
    $("#txtPrice").val("");
    $("#txtCyl").val("");
    $("#txtPass").val("");
    $("#txtType").val("");
    $("#txtImage").val("");
    $("#txtDesc").val("");
    $("#txtCity").val("");
    $("#txtHigh").val("");
}

function saveCar(){
    console.log("Saving the Car...");

    make = $("#txtMake").val();
    model = $("#txtModel").val();
    year = $("#txtYear").val();
    price = $("#txtPrice").val();
    cylinders = $("#txtCyl").val();
    pass = $("#txtPass").val();
    type = $("#txtType").val();
    image = $("#txtImage").val();
    desc = $("#txtDesc").val();
    city = $("#txtCity").val();
    high = $("#txtHigh").val();

// Create the List
    var theList = new Car(make, model, year, price, cylinders, pass, type, image, desc, city, high );
    console.log(theList);
// Send the object on a POST Request
    $.ajax({
        // String, numbers, True and false can only be sent through AJAX
            url: '/Catalog/saveCar',
            type: 'POST',
            data: JSON.stringify(theList),
            contentType: "application/json",
            success: function(res){
                console.log("To the Server: ", res);
                clearForm();
            },
            error: function(details){
                console.log("Error", details);
            }
    });
}

function init(){
    console.log("Register Car Page!");
    

    $("#btnSave").click(saveCar);

}

window.onload = init;