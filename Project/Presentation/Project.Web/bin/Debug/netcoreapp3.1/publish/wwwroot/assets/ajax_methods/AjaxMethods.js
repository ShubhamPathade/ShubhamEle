
//Post Method
const postOrPutData = async ({ type = "POST", controller = "State", endPoint = "AddState", data = null }) => {

    try {

        let response = await $.ajax({
            type: `POST`,
            url: `/${controller}/${endPoint}`,
            data: data,
            success: (response) => {
                return response;
            },
            error: (xhr, status, error) => {
                return {
                    "XHR": xhr,
                    "Staus": status,
                    "Error": error
                };
            }
        });

        return response;

    } catch (e) {

        return {
            "Error": e
        };

    }

}


// Get all data or get data by id
const getData = async ({ controller = "State", endPoint = "AddState", parameter = "id", parameterValue = 0, retriveDataById = false }) => {

    try {

        let dynamicUrl = ``;

        switch (retriveDataById) {
            case true:
                dynamicUrl = `/${controller}/${endPoint}?${parameter}=${parameterValue}`;
                break;
            case false:
                dynamicUrl = `/${controller}/${endPoint}`;
                break;
        }

        let response = await $.ajax({
            type: `GET`,
            url: dynamicUrl,
            success: (response) => {
                return {
                    "Status": 200,
                    "Data": response
                };
            },
            error: (xhr, status, error) => {
                return {
                    "XHR": xhr,
                    "Staus": status,
                    "Error": error
                };
            }
        });

        return response;

    } catch (e) {

        return {
            "Error": e
        };

    }

}


//Fetch data in table 
const fetchDataTable = async ({ dataArray = [], tableId = "",deleteAction=false,viewAction=false } ) => {

    if (dataArray.length > 0) {

        $(`#${tableId}`).empty();

        let objectLength = Object.keys(dataArray[0]).length;

        dataArray.forEach((value, index) => {

            let row = `<td>${index+1}</td>`;

            for (let i = 0; i < (objectLength-1); i++) {

                row += `<td>${Object.values(value)[i]}</td>`;

            }

            let actionBtn = `<td>`;

            if (deleteAction==true) {

                let deleteAction = `<button type="button" onclick="deleteData(${value.id})" class="btn btn-danger"><span class="icon-trash2"></span></button>`;

                actionBtn += deleteAction

            }
          

            if (viewAction == true) {

                let viewAction = `<button type="button" onclick="viewData(${value.id})" class="btn btn-info"><span class="icon-eye"></span></button>`;

                actionBtn += viewAction;

            }

            actionBtn += `</td>`;

            row += actionBtn;

            $(`#${tableId}`).append(`<tr>${row}</tr>`);

        });

    }

}


const deleteData = async ({ primaryKey = 0, controller = "", endPoint="" }) => {

    let keyResponse = await checkArguments(primaryKey);
    if (!keyResponse) {
        return {
            message: keyResponse
        };
    }

    let controllerResponse = await checkArguments(controller);
    if (!controllerResponse) {
        return {
            message: controllerResponse
        };
    }

    let endPointResponse = await checkArguments(endPoint);
    if (!endPointResponse) {
        return {
            message: endPointResponse
        };
    }

    let response = await $.ajax({
        type: `GET`,
        url: `/${controller}/${endPoint}?id=${primaryKey}`,
        success: (response) => {
            return {
                "Status": 200,
                "Data": response
            };
        },
        error: (xhr, status, error) => {
            return {
                "XHR": xhr,
                "Staus": status,
                "Error": error
            };
        }
    });

    return response;

}

const viewData = () => {
    console.log(id);
}

// Fetch data in simple drop down list
const fetchDropDown = async ({ dataArray=[], dropDownId="" }) => {

    $(`#${dropDownId}`).empty();

    let promise = dataArray.map((data, key) => {

        $(`#${dropDownId}`).append(`<option value="${data.id}" >${data.value}</option>`);

        return data;

    });

    const response = await Promise.all(promise);

    return response;

}

// Methods validation
const checkArguments = async (value="") => {

    let message = true;

    switch (value) {
        case undefined:
            message = ` is not defined : ${value}`;
            break;

        case null:
            message = ` is null : ${value}`;
            break;

        case "":
            message = ` is empty : ${value}`;
            break;

        case NaN:
            message = ` is Not a Number : ${value}`
            break;

        case 0:
            message = ` is not valid : ${value}`;
            break;
    }

    return message;

}