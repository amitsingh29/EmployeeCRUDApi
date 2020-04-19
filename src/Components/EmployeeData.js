import { Component } from "react";
import axios from 'axios'

class EmployeeData extends Component
{
    constructor(props) {
        super(props)
        this.state = {
            employee: []
        }
    }
    componentDidMount() {
        axios.get("https://localhost:44396/api/Values/GetAllEmployees")
            .then(response => {
                const employee = response.data;
                this.setState({
                    employee: employee
                })
            })
    }
  
    render() {
        return (
            <>
                <div className="container_first">
                    <p id="record">No Record Found!!</p>
                </div>
                <div className="container_second">
                    <table className="table">
                        <tr>
                            <th>name</th>
                            <th>mobile</th>
                            <th>Email</th>
                            <th>password</th>
                            <th>address</th>
                            <th>Edit</th>
                            <th>Delete</th>
                        </tr>
                        <tbody>
                            {
                                this.state.employee.map(emp =>
                                    <tr key={emp.employee_id}>
                                        <td>{emp.name}</td>
                                        <td>{emp.Email}</td>
                                        <td>{emp.password}</td>
                                        <td>{emp.address}</td>
                                        <td><button>edit</button></td>
                                        <td><button>delete</button></td>
                                    </tr>
                                )
                            }
                        </tbody>
                    </table>
                </div>
            </>
        )
    }
} 
export default EmployeeData;