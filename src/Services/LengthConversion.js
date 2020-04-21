import axios from 'axios';
const meterToCentimeterURL = 'https://localhost:44321/api/Values/MeterToCentimeter';
const centimeterToMeterURL = 'https://localhost:44321/api/Values/CentimeterToMeter';
const feetToInchURL = 'https://localhost:44321/api/Values/FeetToInch';
const inchToFeetURL = 'https://localhost:44321/api/Values/InchToFeet';

export async function meterToCentimeter(data){
   const response = await axios.post(meterToCentimeterURL,data);
   return response;
}

export async function centimeterToMeter(data){
   const response = await axios.post(centimeterToMeterURL,data);
   return response;
}

export async function feetToInch(data){
    const response = await axios.post(feetToInchURL,data);
    return response;
 }
 
 export async function inchToFeet(data){
    const response = await axios.post(inchToFeetURL,data);
    return response;
 }