<?php
    function alter_string_in_file($dir, $old_s, $new_s) {  
        $str = file_get_contents($dir); 
        $str = str_replace($old_s, $new_s, $str);
        file_put_contents($dir, $str);
    }

    function research_the_directory($dir, $old_s, $new_s) {
        if (is_dir($dir)) { 
            //we have a directory 
            if (!str_ends_with($dir, '/') && !str_ends_with($dir, '\\')) {
                $dir = $dir.'\\'; 
            }
            $dh = opendir($dir); 
            while (($file = readdir($dh)) != false) {
                if ($file != '.' && $file != '..') {
                    research_the_directory($dir.$file, $old_s, $new_s); 
                } 
            }
            closedir($dh); 
        } else {
            //we have a file
            alter_string_in_file($dir, $old_s, $new_s); 
        }
    }

    $dir = $_POST["directory"]; 
    $old_s = $_POST["old_string"]; 
    $new_s = $_POST["new_string"]; 

    const path = '\xampp\htdocs\dashboard\report.txt';  //a way to the report file

    if (file_exists($dir)) {
        file_put_contents(path, "Директорий найден\n", FILE_APPEND); 
        try {
            research_the_directory($dir, $old_s, $new_s); 
            file_put_contents(path, "Файлы успешно изменены\n", FILE_APPEND);  
        }
        catch (Exception $e) {
            file_put_contents(path, "Не удалось изменить файлы\n", FILE_APPEND);  
        }
    } else {
        file_put_contents(path, "Директорий не найден\n", FILE_APPEND); 
    }
?>