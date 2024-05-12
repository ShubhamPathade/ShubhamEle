//Post Method
const postData = async ({ type = "POST", controller = "State", endPoint = "AddState", data = null }) => {

    try {
        let response = await $.ajax({
            type: `POST`,
            url: `/${controller}/${endPoint}`,
            data: data,
            success: function (response) {
                return response;
            },
            error: function (xhr, status, error) {
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


