(function ($) {
    abp.widgets.MySimpleWidget = function ($widget) {
        let widgetManager = $widget.data('abp-widget-manager');
        let $commentArea = $widget.find('.comment');

        function init() {
            // append the current date/time to the comment area
            $commentArea.append(new Date().toLocaleString());
        }

        return {
            init: init
        };
    };
})(jQuery);