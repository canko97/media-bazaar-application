

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../public/css/styles.css">
    <title>Document</title>
</head>

<body>
    <?php
        include ("../includes/logic/calendar.php");
        include("../includes/init.php");
        $currentPage = "Calendar"; //Displayed text on the nav changes according to current page
        include "../presentation/navbar/navAdmin.php";
    ?>
    <div class="schedule">
        <?php
            $user = UserLogic::GetUserByEmail("admin@email.com");
            $correctpassword = password_hash("password", PASSWORD_BCRYPT);
            echo $correctpassword;
        ?>
    </div>
</body>
<script src="../public/javascript/javascript.js"></script>
</html>
