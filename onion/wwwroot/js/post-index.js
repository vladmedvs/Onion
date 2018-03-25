(function ($) {
    function post() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-post").on('loaded.bs.modal', function (e) {

            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new post();
        self.init();
    })
}(jQuery))
