/// <binding BeforeBuild='covert' />
var gulp = require('gulp');
/*var sass = require('gulp-sass')*/
var sass = require('gulp-sass')(require('sass'));

gulp.task("covert", function () {
    return gulp.src("wwwroot/sassfiles/t.scss").pipe(sass()).pipe(gulp.dest("wwwroot/css"));
});

//var gulp = require('gulp');
//var concat = require('gulp-concat');
//var cssmin = require('gulp-cssmin');
//var uglify = require('gulp-uglify');

//var paths = {
//    webroot: "wwwroot/"
//};
//paths.MyFile = paths.webroot + "css/site.css"
//paths.mycssFileName = "MyStyle.min.css";
//paths.destinationCssFolder = paths.webroot + "MyStylesMin";

//gulp.task("minify-MyFiles", function () {
//    return gulp.src(paths.MyFile)
//        .pipe(concat(paths.mycssFileName))
//        .pipe(cssmin())
//        .pipe(gulp.dest(paths.destinationCssFolder))
//})