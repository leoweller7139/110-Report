
function fetchCatalog(){
    console.log("Fetching Catalog...");

    $.ajax({
        type: 'GET',
        url: '/Catalog/GetCatalog',
        success: function(res){
            console.log("From Server: ", res);

            // TODO: Sort cars (res = array) to be Cheapest first
            // Sort Array, then Display
            //res.sortListOfCars();
            // var  sortedItems = res.sortListCars;
            // display the var sortedItems

            for(var i=0; i<res.length; i++){
                displayCar(res[i]);
            }
        },
        error: function(details){
            console.log("Error: ", details);
        }
    })
}

function displayCar(car){
    var template = 
    `
    <div class="item">
        <figure class="figure">
            <img class="figure-img img-fluid rounded" src="${car.imageUrl}">
                <figcaption class="figure-caption">
                    <i class="fas gas-pump"> ${car.city} / ${car.high}
                    ${car.cyls}
                    Seats: ${car.passengers}
                    Type: ${car.type}
                </figcaption>
        </figure>


        <div class="car">
            ${car.make}
            ${car.model}
            ${car.year}
        </div>

        <div class="desc">
            ${car.description}
        </div>

        <br>

        <div class="price">
            $${car.dailyPrice} 
            <button type="button" class="btn btn-outline-success">Buy</button>
        </div>

    </div>
    `
    ;

    var container = $("#catalog");
    container.append(template);
}


function init(){
    console.log("Catalog Page!");

    fetchCatalog();
}

window.onload = init;