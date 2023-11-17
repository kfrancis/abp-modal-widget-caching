$(function () {
    abp.log.debug('Index.js initialized!');

    var widgetModal = new abp.ModalManager({
        viewUrl: abp.appPath + "MyWidgetModal"
    });

    $("#openModalBtn").on("click", function (e) {
        e.preventDefault();
        widgetModal.open();
    });
});