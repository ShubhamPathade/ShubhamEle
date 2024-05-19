const toggleToast = ({ bg = "success", title = "", message = "" }) => {

    let toast = $(`   <div
                        class="bs-toast toast toast-placement-ex m-2 fade top-0 end-0 bg-${bg}"
                        role="alert"
                        aria-live="assertive"
                        aria-atomic="true"
                        data-bs-delay="2000">
                        <div class="toast-header">
                          <i class="bx bx-bell me-2"></i>
                          <div class="me-auto fw-medium">${title}</div>
                          <button type="button" class="btn-close" data-bs-dismiss="toast" aria-label="Close"></button>
                        </div>
                        <div class="toast-body">
                          ${message}
                        </div>
                      </div>
    `);

    // Prepend the toast to the container
    $('#toastContainer').prepend(toast);

    // Initialize the Bootstrap toast
    let bsToast = new bootstrap.Toast(toast[0]);

    // Show the toast
    bsToast.show();

    // Automatically hide the toast after a delay
    setTimeout(() => {
        bsToast.hide();
    }, 3000);

}