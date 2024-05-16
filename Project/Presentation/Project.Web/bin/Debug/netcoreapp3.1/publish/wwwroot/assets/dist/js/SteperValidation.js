(function () {
    
    var stepperFormEl = document.querySelector('#stepperForm')
    window.stepperForm = new Stepper(stepperFormEl, {
        animation: true
    })

    var btnNextList = [].slice.call(document.querySelectorAll('.btn-next-form'))
    var btnPrevList = [].slice.call(document.querySelectorAll('.btn-prev-form'))

    //Step 1
    var inputVendorCompanyName = document.getElementById('VendorCompanyName');
    var inputEstablishmentYear = document.getElementById('EstablishmentYear');
    var inputContactPersonName = document.getElementById('ContactPersonName');
    var inputContactPersonEmail = document.getElementById('ContactPersonEmail');
    var inputOfficeAddress = document.getElementById('OfficeAddress');
    var inputZipCode = document.getElementById('ZipCode');
    var inputCityState = document.getElementById('CityState');

    //Step 2
    var inputServiceTypeFTL = document.getElementById('FTL');
    var inputServiceTypePTL = document.getElementById('PTL');

    //Step 3
    var inputAadharNumber = document.getElementById('AadharNumber');
    var inputPanNumber = document.getElementById('PanNumber');

    //Step 4
    var inputBankName = document.getElementById('BankName');
    var inputBankAcNumber = document.getElementById('BankAcNumber');
    var inputIFSCCode = document.getElementById('IFSCCode');
    var inputCancelledCheque = document.getElementById('CancelledCheque');

    //Step 5
    /*var inputTrackingAvailable = document.getElementsByName('IsTrackingAvailable');*/

    btnPrevList.forEach(function (btn) {
        btn.addEventListener('click', function () {
            window.stepperForm.previous()
        })
    })

    btnNextList.forEach(function (btn) {
        btn.addEventListener('click', function (e) {

            //Step 1
            var txtVendorCompanyName = inputVendorCompanyName.value;
            var txtEstablishmentYear = inputEstablishmentYear.value;
            var txtContactPersonName = inputContactPersonName.value;
            var txtContactPersonEmail = inputContactPersonEmail.value;
            var txtOfficeAddress = inputOfficeAddress.value;
            var txtZipCode = inputZipCode.value;
            var txtCityState = inputCityState.value;

            //Step 2
            var chkServiceTypeFTL = inputServiceTypeFTL.checked;
            var chkServiceTypePTL = inputServiceTypePTL.checked;

            //Step 3
            var txtAadharNumber = inputAadharNumber.value;
            var txtPanNumber = inputPanNumber.value;

            //Step 4
            var txtBankName = inputBankName.value;
            var txtBankAcNumber = inputBankAcNumber.value;
            var txtIFSCCode = inputIFSCCode.value;
            var txtCancelledCheque = inputCancelledCheque.value;

            //Step 5
           /* var txtTrackingAvailable = inputTrackingAvailable.value;*/

            var flag = true;
            var emailAddressPattern = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            var pincodePattern = /^[0-9]{6}$/;

            var step1 = document.getElementById('step-profile');
            var step2 = document.getElementById('step-services');
            var step3 = document.getElementById('step-statutory-document');
            var step4 = document.getElementById('step-bank-details');
            /*var step5 = document.getElementById('step-tracking-machanism');*/

            //Step 1
            if (step1.classList.contains('active')) {
                
                if (txtVendorCompanyName == "") {
                    document.getElementById('VendorCompanyNameMessage').innerHTML = "Please enter company name";
                    flag = false;
                }

                if (txtEstablishmentYear == "") {
                    document.getElementById('EstablishmentYearMessage').innerHTML = "Please select Establishment Year";
                    flag = false;
                }

                if (txtContactPersonName == "") {
                    document.getElementById('ContactPersonNameMessage').innerHTML = "Please enter contact person name";
                    flag = false;
                }

                if (txtContactPersonEmail == "") {
                    document.getElementById('ContactPersonEmailMessage').innerHTML = "Please enter email address";
                    flag = false;
                }
                else if (!emailAddressPattern.test(txtContactPersonEmail)) {
                    document.getElementById('ContactPersonEmailMessage').innerHTML = "Please enter valid email address";
                    flag = false;
                }

                if (txtOfficeAddress == "") {
                    document.getElementById('OfficeAddressMessage').innerHTML = "Please enter address";
                    flag = false;
                }

                if (txtZipCode == "") {
                    document.getElementById('ZipCodeMessage').innerHTML = "Please enter zipcode";
                    flag = false;
                }
                else if (!pincodePattern.test(txtZipCode)) {
                    document.getElementById('ZipCodeMessage').innerHTML = "Please enter any 6 digit zipcode";
                    flag = false;
                }

                if (txtCityState == "") {
                    document.getElementById('CityStateMessage').innerHTML = "Please enter city, state";
                    flag = false;
                }       

                if (!flag) {
                    e.preventDefault();
                }
                else
                {
                    document.getElementById('VendorCompanyNameMessage').innerHTML = "";
                    document.getElementById('EstablishmentYearMessage').innerHTML = "";
                    document.getElementById('ContactPersonNameMessage').innerHTML = "";
                    document.getElementById('ContactPersonEmailMessage').innerHTML = "";
                    document.getElementById('OfficeAddressMessage').innerHTML = "";
                    document.getElementById('ZipCodeMessage').innerHTML = "";
                    document.getElementById('CityStateMessage').innerHTML = "";
                    window.stepperForm.next();
                }

                return flag;
            }

            //Step 2
            else if (step2.classList.contains('active')) {

                if (!(chkServiceTypeFTL || chkServiceTypePTL)) {
                    document.getElementById('ServiceTypeMessage').innerHTML = "Please select your prefered service either FTL and PTL";
                    flag = false;
                }

                if (!flag) {
                    e.preventDefault();
                }
                else
                {
                    document.getElementById('ServiceTypeMessage').innerHTML = "";
                    window.stepperForm.next();
                }

                return flag;
            }

            //Step 3
            else if (step3.classList.contains('active')) {

                if (txtAadharNumber == "") {
                    document.getElementById('AadharNumberMessage').innerHTML = "Please enter kyc document number";
                    flag = false;
                }

                if (txtPanNumber == "") {
                    document.getElementById('PanNumberMessage').innerHTML = "Please enter PAN number";
                    flag = false;
                }

                if (!flag) {
                    e.preventDefault();
                }
                else {
                    document.getElementById('AadharNumberMessage').innerHTML = "";
                    document.getElementById('PanNumberMessage').innerHTML = "";
                    window.stepperForm.next();
                }

                return flag;
            }

            //Step 4
            else if (step4.classList.contains('active')) {

                if (txtBankName == "") {
                    document.getElementById('BankNameMessage').innerHTML = "Please enter bank name";
                    flag = false;
                }

                if (txtBankAcNumber == "") {
                    document.getElementById('BankAcNumberMessage').innerHTML = "Please enter bank account number";
                    flag = false;
                }

                if (txtIFSCCode == "") {
                    document.getElementById('IFSCCodeMessage').innerHTML = "Please enter IFSC code";
                    flag = false;
                }

                if (txtCancelledCheque == "") {
                    document.getElementById('CancelledChequeMessage').innerHTML = "Please choose file";
                    flag = false;
                }
                if (txtCancelledCheque != "") {
                    let fileSize = $('#CancelledCheque')[0].files[0].size;
                    let fileType = $('#CancelledCheque')[0].files[0].type;

                    if (!(fileType == "application/pdf" || fileType == "image/jpeg" || fileType == "image/jpg")) {
                        document.getElementById('CancelledChequeMessage').innerHTML = "You can only upload pdf, jpg and jpeg file";
                        flag = false;
                    }
                    else if (fileSize > 3000000) {
                        document.getElementById('CancelledChequeMessage').innerHTML = "Please select file size less than or equals 3 MB";
                        flag = false;
                    }
                }

                if (!flag) {
                    e.preventDefault();
                }
                else {
                    document.getElementById('BankNameMessage').innerHTML = "";
                    document.getElementById('BankAcNumberMessage').innerHTML = "";
                    document.getElementById('IFSCCodeMessage').innerHTML = "";
                    document.getElementById('CancelledChequeMessage').innerHTML = "";
                    window.stepperForm.next();
                }

                return flag;
            }

            ////Step 5
            //else if (step5.classList.contains('active')) {
            //    debugger
            //    if (txtTrackingAvailable == "") {
            //        document.getElementById('TrackingAvailableMessage').innerHTML = "Please select tracking mechanism";
            //        flag = false;
            //    }

            //    if (!flag) {
            //        e.preventDefault();
            //    }
            //    else {
            //        document.getElementById('TrackingAvailableMessage').innerHTML = "";
            //        window.stepperForm.next();
            //    }

            //    return flag;
            //}

        })
    })

})()


var emailAddressPattern = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
var mobileNumberPattern = /^[6789][0-9]{9}$/;
var pincodePattern = /^[0-9]{6}$/;

//Step 1
var vendorCompanyNameEvent = document.getElementById('VendorCompanyName');
vendorCompanyNameEvent.addEventListener('keyup', vendorCompanyNameFunction);

function vendorCompanyNameFunction() {
    var txtVendorCompanyName = document.getElementById('VendorCompanyName').value;
    if (txtVendorCompanyName == "") {
        document.getElementById('VendorCompanyNameMessage').innerHTML = "Please enter company name";
    }
    else if (txtVendorCompanyName != "") {
        document.getElementById('VendorCompanyNameMessage').innerHTML = "";
    }
}

var establishmentYearEvent = document.getElementById('EstablishmentYear');
establishmentYearEvent.addEventListener('keyup', establishmentYearFunction);

function establishmentYearFunction() {
    var txtEstablishmentYear = document.getElementById('EstablishmentYear').value;
    if (txtEstablishmentYear == "") {
        document.getElementById('EstablishmentYearMessage').innerHTML = "Please select Establishment Year";
    }
    else if (txtEstablishmentYear != "") {
        document.getElementById('EstablishmentYearMessage').innerHTML = "";
    }
}

var contactPersonNameEvent = document.getElementById('ContactPersonName');
contactPersonNameEvent.addEventListener('keyup', contactPersonNameFunction);

function contactPersonNameFunction() {
    var txtContactPersonName = document.getElementById('ContactPersonName').value;
    if (txtContactPersonName == "") {
        document.getElementById('ContactPersonNameMessage').innerHTML = "Please enter contact person name";
    }
    else if (txtContactPersonName != "") {
        document.getElementById('ContactPersonNameMessage').innerHTML = "";
    }
}

var contactPersonEmailEvent = document.getElementById('ContactPersonEmail');
contactPersonEmailEvent.addEventListener('keyup', contactPersonEmailFunction);

function contactPersonEmailFunction() {
    var txtContactPersonEmail = document.getElementById('ContactPersonEmail').value;
    if (txtContactPersonEmail == "") {
        document.getElementById('emailMessage').innerHTML = "Please enter email address";
    }
    if (!emailAddressPattern.test(txtContactPersonEmail)) {
         document.getElementById('ContactPersonEmailMessage').innerHTML = "Please enter valid email address";
    }
    else if (emailAddressPattern.test(txtContactPersonEmail)) {
         document.getElementById('ContactPersonEmailMessage').innerHTML = "";
    }
}

var officeAddressEvent = document.getElementById('OfficeAddress');
officeAddressEvent.addEventListener('keyup', officeAddressFunction);

function officeAddressFunction() {
    var txtOfficeAddress = document.getElementById('OfficeAddress').value;
    if (txtOfficeAddress == "") {
        document.getElementById('OfficeAddressMessage').innerHTML = "Please enter address";
    }
    else if (txtOfficeAddress != "") {
        document.getElementById('OfficeAddressMessage').innerHTML = "";
    }
}

var zipCodeEvent = document.getElementById('ZipCode');
zipCodeEvent.addEventListener('keyup', zipCodeFunction);

function zipCodeFunction() {
    var txtZipCode = document.getElementById('ZipCode').value;
    if (txtZipCode == "") {
        document.getElementById('ZipCodeMessage').innerHTML = "Please enter zipcode";
    }
    else if (!pincodePattern.test(txtZipCode)) {
        document.getElementById('ZipCodeMessage').innerHTML = "Please enter valid zipcode";
    }
    else if (pincodePattern.test(txtZipCode)) {
        document.getElementById('ZipCodeMessage').innerHTML = "";
    }
}

var cityStateEvent = document.getElementById('CityState');
cityStateEvent.addEventListener('keyup', cityStateFunction);

function cityStateFunction() {
    var txtCityState = document.getElementById('CityState').value;
    if (txtCityState == "") {
        document.getElementById('CityStateMessage').innerHTML = "Please enter city, state";
    }
    else if (txtCityState != "") {
        document.getElementById('CityStateMessage').innerHTML = "";
    }
}

//Step 2
var serviceTypeFTLEvent = document.getElementById('FTL');
serviceTypeFTLEvent.addEventListener('change', serviceTypeFunction);

var serviceTypePTLEvent = document.getElementById('PTL');
serviceTypePTLEvent.addEventListener('change', serviceTypeFunction);

function serviceTypeFunction() {
    var txtServiceTypeFTL = document.getElementById('FTL').checked;
    var txtServiceTypePTL = document.getElementById('PTL').checked;
    if (txtServiceTypeFTL || txtServiceTypePTL) {
        document.getElementById('ServiceTypeMessage').innerHTML = "";
    }
    else if (!(txtServiceTypeFTL || txtServiceTypePTL )) {
        document.getElementById('ServiceTypeMessage').innerHTML = "Please select your prefered service either FTL and PTL";
    }
}

//Step 3
var aadharNumberEvent = document.getElementById('AadharNumber');
aadharNumberEvent.addEventListener('keyup', aadharNumberFunction);

function aadharNumberFunction() {
    var txtAadharNumber = document.getElementById('AadharNumber').value;
    if (txtAadharNumber == "") {
        document.getElementById('AadharNumberMessage').innerHTML = "Please enter kyc document number";
    }
    else if (txtAadharNumber != "") {
        document.getElementById('AadharNumberMessage').innerHTML = "";
    }
}

var panNumberEvent = document.getElementById('PanNumber');
panNumberEvent.addEventListener('keyup', panNumberFunction);

function panNumberFunction() {
    var txtPanNumber = document.getElementById('PanNumber').value;
    if (txtPanNumber == "") {
        document.getElementById('PanNumberMessage').innerHTML = "Please enter PAN number";
    }
    else if (txtPanNumber != "") {
        document.getElementById('PanNumberMessage').innerHTML = "";
    }
}