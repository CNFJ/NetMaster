"use strict";
var gulp = require("gulp"),
rimraf = require("rimraf"),
concat = require("gulp-concat"),
cssmin = require("gulp-cssmin"),
uglify = require("gulp-uglify")
 
var paths = {
    webroot: "./wwwroot/"
};
paths.node_modules_libs = [
    'node_modules/jquery/dist/jquery.js',
    'node_modules/jquery/dist/jquery.min.js',
    'node_modules/bootstrap/dist/js/bootstrap.js',
    "node_modules/bootstrap/dist/js/bootstrap.min.js",
   
    'node_modules/bootstrap/dist/css/bootstrap.css',
    "node_modules/bootstrap/dist/css/bootstrap.min.css"
]
paths.lib = paths.webroot + 'lib/js/*.js';
paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.concatJsDest = paths.webroot + "js/site.min.js";


gulp.task('libJs', async () =>{     //复制npm包到web root中
    await  gulp.src(paths.node_modules_libs).pipe(gulp.dest(paths.webroot + 'lib'));
});

 
gulp.task("clean:js", function (cb) {   //清理压缩后的js文件
    rimraf(paths.concatJsDest, cb);
});
gulp.task("min:js", async () => {  //将需要的js压缩并合并成一个文件以减少http请求数
  await  gulp.src([paths.js, "!" + paths.minJs, paths.lib], { base: "." }).pipe(concat(paths.concatJsDest))
    .pipe(uglify())
    .pipe(gulp.dest("."));
});