
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


const deleteData = async (id) => {
    console.log(id);
}

const viewData = () => {
    console.log(id);
}