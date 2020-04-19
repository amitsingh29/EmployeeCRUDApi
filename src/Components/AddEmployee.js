import { Component } from "react";
import axios from 'axios'

class AddEmployee extends Component
{ constructor(props) {
    super(props)
    this.state = {
        fname: '',
        lname: '',
        email: '',
        gender: '',
        mobile: '',
        password:''
    };
}
onSubmit = event => {
    event.preventDefault();
    console.log( "fname is ",this.props.fname);
    
    const employee = {
        firstName: this.props.fname,
        lastName: this.props.lname,
        emailId: this.props.email,
        gender: this.props.gender,
        mobileNumber: this.props.mobile,
        password: this.props.password
    }
    axios.post('https://localhost:44396/api/Values/Addemployee', employee)
        .then(res => console.log(res));
}
render(){
return(
    <div className = "div-btn" >
        <button id="btn" className="button" onClick={this.onSubmit}>Add Employee</button>
    </div>
)
}
}


