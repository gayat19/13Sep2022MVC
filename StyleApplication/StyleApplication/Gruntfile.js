var grunt = require('grunt');

module.exports = function (grunt) {
    grunt.initConfig({
        sass: {
            dist: {
                files: [{
                    expand: true,
                    cwd: 'sassfiles',
                    src: ['**/*.scss'],
                    dest: 'wwwroot/styles',
                    ext: '.css'
                }]
            }
        }
    });
    grunt.loadNpmTasks("grunt-sass");
    //grunt.registerTask('checkTask', 'greet', function () {
    //    grunt.log.write('Hello all').ok();
    //});
    grunt.registerTask('MyTask', ['sass']);
}