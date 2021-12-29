<!DOCTYPE html>
<html lang="en">
<head>
      <meta charset="UTF-8">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <link rel="stylesheet" href="../public/css/styles.css">
      <title>Document</title>
</head>
<body class="login_body">
      <div class="login_page">
            <div class="login_form">
                  <div class="container">
                        <h1>Log In</h1> 
                  </div>
            <form action="../includes/logic/UserInfo.php" method="POST">
                  <input type="email" name="email" placeholder="email"/>
                  <input type="password" name ="password"placeholder="password"/>
                  <button type="submit" name="login">Log in</button>
            </form>
            </div>
      </div>
</body>
</html>