# My-Works
<h4> CSS </h4>

@import url('https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;500;600&display=swap');
*{
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: 'Poppins', sans-serif;
} 

body{
  min-height: 100vh;
  display: flex;
  align-items: center;
  justify-content: center;
  background: #4070f4;
}

.container{
  position: relative;
  max-width: 900px;
  width: 100%;
  border-radius: 6px;
  padding: 30px;
  margin: 0 15px;
  background-color: #fff;
  box-shadow: 0 5px 10px rgba(0,0,0,0.1);
}

.container header{
  position: ralative;
  font-size: 20px;
  font-weight: 600;
  color: fff;
}

.container form{
  position: relative;
  margin-top: 16px;
  min-height: 490px;
  background-color: #fff;
}


<h4> HTML </h4>

<!DOCTYPE html>
<html>

<head>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width">
  <title>Registration Form</title>
  <link href="style.css" rel="stylesheet" type="text/css" />
  <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>

<body>
  <div class="container">
        <header>Registration</header>
    
        <form action="#">
          <div class="form first">
            <div class="details personal">
              <span class="title">Personal Details</span>

              <div class="fields">
                <div class="input-field">
                  <label>Full Name</label>
                  <input type="text" placeholder="Enter your name" required>
                </div>
              </div>
            </div>
          </div>
        </form>
    </div>
  <script src="script.js"></script>
</body>

</html>
