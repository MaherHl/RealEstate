import React from 'react'
import SideBare from '../Components/SideBare';


function AddForm() {
  return (
    <div className="bg-gray-100  h-screen">
   
    <SideBare className='' />

    <div className='ps-60 py-20  bg-gray-100'>
        
<form className='mt-12 mx-4 bg-gray-100  '>
    <div class="grid gap-6 mb-6 md:grid-cols-2">
        <div>
            <label for="first_name" class="block mb-2 text-sm font-medium text-gray-900 "> Property name</label>
            <input type="text" id="first_name" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder=" Property name" required />
        </div>
        <div>
            <label for="last_name" class="block mb-2 text-sm font-medium text-gray-900 ">Price</label>
            <input type="text" id="last_name" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="000000" required />
        </div>
        <div className=''>
        <label for="default" class="block mb-2 text-sm font-medium text-gray-900 ">Default select</label>
  <select id="default" class="bg-gray-50 border border-blue-700 text-gray-900  text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 ">
    <option selected>Choose a country</option>
    <option value="US">United States</option>
    <option value="CA">Canada</option>
    <option value="FR">France</option>
    <option value="DE">Germany</option>
  </select>
        </div>  
        <div>
        <label for="default" class="block mb-2 text-sm font-medium text-gray-900 ">Default select</label>
  <select id="default" class="bg-gray-50 border border-blue-700 text-gray-900  text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 ">
    <option selected>Choose a country</option>
    <option value="US">United States</option>
    <option value="CA">Canada</option>
    <option value="FR">France</option>
    <option value="DE">Germany</option>
  </select>
        </div>  
        <div>
        <label for="rooms" class="block mb-2 text-sm font-medium text-gray-900 ">Rooms</label>
        <input type="Number" id="email" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="6" required />
        </div>
        <div>
            <label for="visitors" class="block mb-2 text-sm font-medium text-gray-900 ">City</label>
            <input type="number" id="visitors" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="CasaBlanca" required />
        </div>
        <div class="">
    <label for="website" class="block mb-2 text-sm font-medium text-gray-900 ">Google Maps Adress</label>
            <input type="url" id="website" class="bg-gray-50 border border-blue-700 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5  " placeholder="XXXX" required />
        
    </div> 
    <div>
        
    <div class="flex  pt-10">
    <div class="flex items-center ">
        <input id="inline-checkbox" type="checkbox" value="" class="w-4 h-4 text-blue-600 bg-blue-700 border-gray-300 rounded focus:ring-blue-500 "/>
        <label for="inline-checkbox" class="ms-2 text-sm font-medium text-gray-900">the Client Can Bring Pets in the Facility </label>
    </div>
 

    </div>
      

    </div>
    <div class="">
      
      <label for="message" class="block mb-2 text-sm font-medium text-gray-900 ">Your Discription</label>
      <textarea id="message" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-white rounded-lg border border-blue-700 focus:ring-blue-500 focus:border-blue-500  " placeholder="Write your thoughts here..."></textarea>
      
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
        <input id="dropzone-file" type="file" class="hidden" />
    </label>

</div> 


    </div>
    
    <button class="flex items-center justify-between w-full px-6 py-3 text-sm tracking-wide text-white capitalize transition-colors duration-300 transform bg-blue-500 rounded-md hover:bg-blue-400 focus:outline-none focus:ring focus:ring-blue-300 focus:ring-opacity-50">
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

