(function() {
    'use strict';

    //get root path and entry point from the data attributes on the script
    var $requireEl = document.querySelector('[data-main]');
    var entryPoint = $requireEl.dataset.module;
    var rootPath = $requireEl.dataset.path;

    // configure requirejs base path and library dependencies
    require.config({
        baseUrl: rootPath + 'Scripts'
    });

    // then call the entry point if specified
    if (entryPoint) {
        require([entryPoint]);
    }
}());