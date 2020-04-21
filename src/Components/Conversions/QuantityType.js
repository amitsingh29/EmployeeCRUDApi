import React, { Component } from 'react';
class QuantityType extends Component {
    
    render() {
        return (
            <select className='select-type'  onChange={this.props.quantityTypeChanged}>
                <option value="-1" selected>Select</option>
                <option name="length">Length</option>
                <option name="weight">Weight</option>
            </select>
        )
    }
}
export default QuantityType;