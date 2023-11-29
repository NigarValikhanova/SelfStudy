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
.container form .details{
  margin-top: 30px;
}

.container form .details.ID{
  margin-top: 10px;
}
.container form .title{
  display: block;
  margin-bottom: 8px;
  font-size: 16px;
  font-weight: 500;
  margin: 6px 0;
  color: #333;
}
.container form .fields{
  display: flex;
  align-items: center;
  justify-content: space-between;
  flex-wrap: wrap;
}
form .fields .input-field{
  display: flex;
  width: calc(100% / 3 - 15px);
  flex-direction: column;
  margin: 4px 0;;
}
.input-field label{
  font-size: 12px;
  font-weight: 500;
  color: #2e2e2e;
}
.input-field input{
  outline: none;
  font-size: 14px;
  font-weight: 400;
  color: #333;
  border-radius: 5px;
  border: 1px solid #aaa;
  padding: 0 15px;
  height: 42px;
  margin: 8px 0;
}
.input-field input:is(:focus, :valid){
  box-shadow: 0 3px 6px rgba(0,0,0,0.13);
}
.input-field input[type="date"]{
  color:#707070;
}
.input-field input[type="date"]:valid{
  color:#333;
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

                <div class="input-field">
                  <label>Date of Birth</label>
                  <input type="date" placeholder="Enter birth date" required>
                </div>

                <div class="input-field">
                  <label>Email</label>
                  <input type="text" placeholder="Enter your email" required>
                </div>

                <div class="input-field">
                  <label>Mobile Number</label>
                  <input type="text" placeholder="Enter mobile number" required>
                </div>

                <div class="input-field">
                  <label>Gender</label>
                  <input type="text" placeholder="Enter your gender" required>
                </div>

                <div class="input-field">
                  <label>Occupation</label>
                  <input type="text" placeholder="Enter your occupation" required>
                </div>
              </div>


              <div class="details ID">
                <span class="title">Identity Details</span>

                <div class="fields">
                  <div class="input-field">
                    <label>ID Type</label>
                    <input type="text" placeholder="Enter ID type" required>
                  </div>

                  <div class="input-field">
                    <label>ID Number</label>
                    <input type="number" placeholder="Enter ID number" required>
                  </div>

                  <div class="input-field">
                    <label>Issued Authority</label>
                    <input type="text" placeholder="Enter issued authority" required>
                  </div>

                  <div class="input-field">
                    <label>Issued State</label>
                    <input type="text" placeholder="Enter issued state" required>
                  </div>

                  <div class="input-field">
                    <label>Issued Date</label>
                    <input type="date" placeholder="Enter issued date" required>
                  </div>

                  <div class="input-field">
                    <label>Expiry Date</label>
                    <input type="date" placeholder="Enter expiry date" required>
                  </div>
                </div>
            </div>
          </div>
        </form>
    </div>
  <script src="script.js"></script>
</body>

</html>
