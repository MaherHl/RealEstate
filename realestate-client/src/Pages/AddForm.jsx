import React from 'react'
import SideBare from '../Components/SideBare';
import { useState } from 'react';
import axios from 'axios';
import { useSelector } from 'react-redux';
import { useNavigate } from 'react-router';


function AddForm() {
    const navigate = useNavigate();
      
  const agent = useSelector((state)=>state.user)
  const auth =  useSelector((state) => state.token)
  const addFacilty= async (e)=>{
    e.preventDefault();
    const formData = new FormData();
    formData.append('FacilityName',FacilityName);
    formData.append('PropertyType',PropertyType);
    formData.append('Price',Price);
    formData.append('availability',availability);
    formData.append('rentingType',rentingType);
    formData.append('PictureFile',picture); // Append picture file
    formData.append('description',description);
    formData.append('location',location);
    formData.append('City',City);
    formData.append('rooms',rooms);
    formData.append('isPetFriendly',isPetFriendly);
    try{
        console.log(formData)
        await axios.post(`https://localhost:7108/AddFacility/${agent._Id}`,formData,{
            headers: {
                'Content-Type': 'multipart/form-data',
                'Authorization': `Bearer ${auth}` 
            },      
    
        })
        alert('Facility added successfully');
        navigate('/Dashboard')
      }

     catch(error){
        console.error('Error adding facility:', error);
        alert('Error adding facility. Please try again.');

    }}
    const [FacilityName ,setFacilityName]= useState('')
    const [PropertyType , setPropertyType]= useState('')
    const [Price , setPrice]= useState('')
    const [availability, setAvailability] = useState(true)
    const [rentingType, setRentingType]= useState('Monthly')
    const [picture, setPicture] = useState(null)
    const [description, setDescription]= useState('')
    const [location, setLocation] = useState('')
    const [City, setCity]= useState('')
    const [rooms,setRooms]= useState()
    const [isPetFriendly, setisPetFriendly]=useState('')
    const handleCheckboxChange = (e) => {
        setisPetFriendly(e.target.checked);
      };

  return (
    <div className="bg-gray-100  h-screen">
   
    <SideBare agent={agent} token={auth} className='' />

    <div className='ps-60 py-20  bg-gray-100'>
        
<form className='mt-12 mx-4 bg-gray-100  '>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <div>
            <label for="first_name" class="block mb-2 text-sm font-medium text-gray-900 "> Property name</label>
            <input  onChange={(e)=>setFacilityName(e.target.value)}  type="text" id="FacilityName" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder=" Property name" required />
        </div>
        <div>
            <label for="last_name" class="block mb-2 text-sm font-medium text-gray-900 ">Price</label>
            <input  onChange={(e)=>setPrice(e.target.value)}  type="number" id="Price" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="000000" required />
        </div>
        <div className=''>
        <label for="default" class="block mb-2 text-sm font-medium text-gray-900 ">Renting Type</label>
  <select id="default" onChange={(e)=>setRentingType(e.target.value)}  class="bg-gray-50 border border-blue-700 text-gray-900  text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 ">

    <option value="Daily">Daily</option>
    <option  selected value="Monthly">Monthly</option>
 
  </select>
        </div>  
        <div>
        <label for="default" class="block mb-2 text-sm font-medium text-gray-900 ">Property Type </label>
  <select onChange={(e)=>setPropertyType(e.target.value)} id="default" class="bg-gray-50 border border-blue-700 text-gray-900  text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 ">
    <option value="appartement">appartement</option>
    <option value="Desk">Desk</option>
    <option value="Studio">Studio</option>
  
  </select>
        </div>  
        <div>
        <label for="rooms" class="block mb-2 text-sm font-medium text-gray-900 ">Rooms</label>
        <input onChange={(e)=>setRooms(e.target.value)}  type="Number" id="rooms" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="6" required />
        </div>
        <div>
            <label for="city" class="block mb-2 text-sm font-medium text-gray-900 ">City</label>
            <input type="text"onChange={(e)=>setCity(e.target.value)} id="city" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="CasaBlanca" required />
        </div>
        <div class="">
    <label for="location" class="block mb-2 text-sm font-medium text-gray-900 ">Google Maps Adress</label>
            <input type="text"  onChange={(e)=>setLocation(e.target.value)}  id="website" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="XXXX" required />
        
    </div> 
    <div>
        
    <div class="flex  pt-10">
    <div class="flex items-center ">
        <input id="inline-checkbox"  name='isPetFriendly' onChange={handleCheckboxChange}  type="checkbox"  class="w-4 h-4 text-blue-600 bg-blue-700 border-gray-300 rounded focus:ring-blue-500 "/>
        <label for="inline-checkbox" class="ms-2 text-sm font-medium text-gray-900">the Client Can Bring Pets in the Facility </label>
    </div>
 

    </div>
      

    </div>
    <div class="">
      
      <label for="message" class="block mb-2 text-sm font-medium text-gray-900 ">Your Discription</label>
      <textarea id="Description" onChange={(e)=>setDescription(e.target.value)} rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-white rounded-lg border border-blue-700 focus:ring-blue-500 focus:border-blue-500  " placeholder="Write your thoughts here..."></textarea>
      
          </div> 
    <div>
        
<div class="flex items-center justify-center w-full">
    <label for="dropzone-file" class="flex flex-col items-center justify-center w-full h-30 border-2 border-gray-300 border-dashed rounded-lg cursor-pointer bg-white ">
        <div class="flex flex-col items-center justify-center pt-5 pb-6">
            <svg class="w-8 h-8 mb-4 text-gray-500 " aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 20 16">
                <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M13 13h3a3 3 0 0 0 0-6h-.025A5.56 5.56 0 0 0 16 6.5 5.5 5.5 0 0 0 5.207 5.021C5.137 5.017 5.071 5 5 5a4 4 0 0 0 0 8h2.167M10 15V6m0 0L8 8m2-2 2 2"/>
            </svg>
            <p class="mb-2 text-sm text-gray-500 "><span class="font-semibold">Click to upload</span> or drag and drop</p>
            <p class="text-xs text-gray-500 ">SVG, PNG, JPG or GIF (MAX. 800x400px)</p>
        </div>
        <input   onChange={(e)=>setPicture(e.target.files[0])}  id="dropzone-file" type="file" class="hidden" />
    </label>

</div> 


    </div>
    
    <button type='submit' onClick={addFacilty} class="flex items-center justify-between w-full px-6 py-3 text-sm tracking-wide text-white capitalize transition-colors duration-300 transform bg-blue-500 rounded-md hover:bg-blue-400 focus:outline-none focus:ring focus:ring-blue-300 focus:ring-opacity-50">
                        <span>Submit </span>

                        <svg xmlns="http://www.w3.org/2000/svg" class="w-5 h-5 rtl:-scale-x-100" viewBox="0 0 20 20" fill="currentColor">
                            <path fill-rule="evenodd"
                                  d="M7.293 14.707a1 1 0 010-1.414L10.586 10 7.293 6.707a1 1 0 011.414-1.414l4 4a1 1 0 010 1.414l-4 4a1 1 0 01-1.414 0z"
                                  clip-rule="evenodd" />
                        </svg>
                    </button>
    </div>
   
 
 
   
</form>

    </div>
    </div>
  )
}

export default AddForm

