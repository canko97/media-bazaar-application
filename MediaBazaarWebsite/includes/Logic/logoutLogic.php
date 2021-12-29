<?php
      session_start();
      session_destroy();

      header("Location: ../../presentation/login.php");
