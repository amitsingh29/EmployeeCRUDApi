import axios from 'axios';
const kilogramToGramURL = 'https://localhost:44321/api/Values/KilogramToGram';
const gramToKilogramURL = 'https://localhost:44321/api/Values/GramToKilogram';

export async function kilogramToGram(data){
    const response = await axios.post(kilogramToGramURL,data);
    return response;
 }
 export async function gramToKilogram(data){
    const response = await axios.post(gramToKilogramURL,data);
    return response;
 }