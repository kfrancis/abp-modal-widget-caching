(function ($) {
    abp.widgets.MySimpleWidget = function ($widget) {
        let widgetManager = $widget.data('abp-widget-manager');

        /*
        * Automatically called because AutoInitialize = true on the ViewComponent
        */
        function init() {
            setComment($widget);
        }

        function setComment($container) {
            // append the current date/time to the comment area
            $widget.find('.widgetContent').text(new Date().toLocaleString());
        }

        return {
            init: init
        };
    };
})(jQuery);