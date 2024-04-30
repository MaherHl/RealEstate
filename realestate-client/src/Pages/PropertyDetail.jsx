import React from 'react'
import { useState , useRef} from 'react'
import Navbar from '../Components/Navbar'
import Contact from '../Assets/Contact.png'
import { Datepicker } from 'flowbite-react'

import { InboxArrowDownIcon, PhoneArrowDownLeftIcon , UserIcon, b} from '@heroicons/react/24/outline'
import { FaBed,FaBath  ,FaToilet } from 'react-icons/fa6'


function PropertyDetail() {

  return (
    <div>
        <Navbar/>
                <section class="relative  m-10">
               
        <div class="w-full mx-auto px-4 sm:px-6 lg:px-0">
            <div class="grid grid-cols-1 lg:grid-cols-2 gap-16 mx-auto max-md:px-2 ">
                <div class="img">
                    <div class="img-box h-100 max-lg:mx-auto ">
                        <img src="https://pagedone.io/asset/uploads/1700471600.png" alt="Yellow Tropical Printed Shirt image"
                            class="max-lg:mx-auto rounded-6  lg:ml-auto h-full"/>
                    </div>
                </div>
                <div
                    class="data w-full lg:pr-8 pr-0 xl:justify-start justify-center flex items-center max-lg:pb-10 xl:my-2 lg:my-5 my-0">
                    <div class="data w-full max-w-xl">
                        <p class="text-lg font-medium leading-8 text-indigo-600 mb-4"> Property&nbsp; /&nbsp;Detail
                        </p>
                       
                        <h2 class="font-manrope font-bold text-3xl leading-10 text-gray-900 mb-2 capitalize">Basic
                            Property Name </h2>
                            <div class="p-4 mb-4 text-sm text-lg text-emerald-500 rounded-xl bg-emerald-50 font-normal" role="alert">
                            <span class="font-semibold mr-2">SPECIAL OFFER </span> First Mounth is free of charge
                          </div>
                        <div class="flex flex-col sm:flex-row sm:items-center mb-6">
                            <h6
                                class="font-manrope font-semibold text-2xl leading-9 text-gray-900 pr-5 sm:border-r border-gray-200 mr-5">
                                $220</h6>
                            <div class="flex items-center gap-2">
                                <div class="flex items-center gap-1">
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <g clip-path="url(#clip0_12029_1640)">
                                            <path
                                                d="M9.10326 2.31699C9.47008 1.57374 10.5299 1.57374 10.8967 2.31699L12.7063 5.98347C12.8519 6.27862 13.1335 6.48319 13.4592 6.53051L17.5054 7.11846C18.3256 7.23765 18.6531 8.24562 18.0596 8.82416L15.1318 11.6781C14.8961 11.9079 14.7885 12.2389 14.8442 12.5632L15.5353 16.5931C15.6754 17.41 14.818 18.033 14.0844 17.6473L10.4653 15.7446C10.174 15.5915 9.82598 15.5915 9.53466 15.7446L5.91562 17.6473C5.18199 18.033 4.32456 17.41 4.46467 16.5931L5.15585 12.5632C5.21148 12.2389 5.10393 11.9079 4.86825 11.6781L1.94038 8.82416C1.34687 8.24562 1.67438 7.23765 2.4946 7.11846L6.54081 6.53051C6.86652 6.48319 7.14808 6.27862 7.29374 5.98347L9.10326 2.31699Z"
                                                fill="#FBBF24" />
                                        </g>
                                        <defs>
                                            <clipPath id="clip0_12029_1640">
                                                <rect width="20" height="20" fill="white" />
                                            </clipPath>
                                        </defs>
                                    </svg>
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <g clip-path="url(#clip0_12029_1640)">
                                            <path
                                                d="M9.10326 2.31699C9.47008 1.57374 10.5299 1.57374 10.8967 2.31699L12.7063 5.98347C12.8519 6.27862 13.1335 6.48319 13.4592 6.53051L17.5054 7.11846C18.3256 7.23765 18.6531 8.24562 18.0596 8.82416L15.1318 11.6781C14.8961 11.9079 14.7885 12.2389 14.8442 12.5632L15.5353 16.5931C15.6754 17.41 14.818 18.033 14.0844 17.6473L10.4653 15.7446C10.174 15.5915 9.82598 15.5915 9.53466 15.7446L5.91562 17.6473C5.18199 18.033 4.32456 17.41 4.46467 16.5931L5.15585 12.5632C5.21148 12.2389 5.10393 11.9079 4.86825 11.6781L1.94038 8.82416C1.34687 8.24562 1.67438 7.23765 2.4946 7.11846L6.54081 6.53051C6.86652 6.48319 7.14808 6.27862 7.29374 5.98347L9.10326 2.31699Z"
                                                fill="#FBBF24" />
                                        </g>
                                        <defs>
                                            <clipPath id="clip0_12029_1640">
                                                <rect width="20" height="20" fill="white" />
                                            </clipPath>
                                        </defs>
                                    </svg>
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <g clip-path="url(#clip0_12029_1640)">
                                            <path
                                                d="M9.10326 2.31699C9.47008 1.57374 10.5299 1.57374 10.8967 2.31699L12.7063 5.98347C12.8519 6.27862 13.1335 6.48319 13.4592 6.53051L17.5054 7.11846C18.3256 7.23765 18.6531 8.24562 18.0596 8.82416L15.1318 11.6781C14.8961 11.9079 14.7885 12.2389 14.8442 12.5632L15.5353 16.5931C15.6754 17.41 14.818 18.033 14.0844 17.6473L10.4653 15.7446C10.174 15.5915 9.82598 15.5915 9.53466 15.7446L5.91562 17.6473C5.18199 18.033 4.32456 17.41 4.46467 16.5931L5.15585 12.5632C5.21148 12.2389 5.10393 11.9079 4.86825 11.6781L1.94038 8.82416C1.34687 8.24562 1.67438 7.23765 2.4946 7.11846L6.54081 6.53051C6.86652 6.48319 7.14808 6.27862 7.29374 5.98347L9.10326 2.31699Z"
                                                fill="#FBBF24" />
                                        </g>
                                        <defs>
                                            <clipPath id="clip0_12029_1640">
                                                <rect width="20" height="20" fill="white" />
                                            </clipPath>
                                        </defs>
                                    </svg>
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <g clip-path="url(#clip0_12029_1640)">
                                            <path
                                                d="M9.10326 2.31699C9.47008 1.57374 10.5299 1.57374 10.8967 2.31699L12.7063 5.98347C12.8519 6.27862 13.1335 6.48319 13.4592 6.53051L17.5054 7.11846C18.3256 7.23765 18.6531 8.24562 18.0596 8.82416L15.1318 11.6781C14.8961 11.9079 14.7885 12.2389 14.8442 12.5632L15.5353 16.5931C15.6754 17.41 14.818 18.033 14.0844 17.6473L10.4653 15.7446C10.174 15.5915 9.82598 15.5915 9.53466 15.7446L5.91562 17.6473C5.18199 18.033 4.32456 17.41 4.46467 16.5931L5.15585 12.5632C5.21148 12.2389 5.10393 11.9079 4.86825 11.6781L1.94038 8.82416C1.34687 8.24562 1.67438 7.23765 2.4946 7.11846L6.54081 6.53051C6.86652 6.48319 7.14808 6.27862 7.29374 5.98347L9.10326 2.31699Z"
                                                fill="#FBBF24" />
                                        </g>
                                        <defs>
                                            <clipPath id="clip0_12029_1640">
                                                <rect width="20" height="20" fill="white" />
                                            </clipPath>
                                        </defs>
                                    </svg>
                                    <svg width="20" height="20" viewBox="0 0 20 20" fill="none"
                                        xmlns="http://www.w3.org/2000/svg">
                                        <g clip-path="url(#clip0_8480_66029)">
                                            <path
                                                d="M9.10326 2.31699C9.47008 1.57374 10.5299 1.57374 10.8967 2.31699L12.7063 5.98347C12.8519 6.27862 13.1335 6.48319 13.4592 6.53051L17.5054 7.11846C18.3256 7.23765 18.6531 8.24562 18.0596 8.82416L15.1318 11.6781C14.8961 11.9079 14.7885 12.2389 14.8442 12.5632L15.5353 16.5931C15.6754 17.41 14.818 18.033 14.0844 17.6473L10.4653 15.7446C10.174 15.5915 9.82598 15.5915 9.53466 15.7446L5.91562 17.6473C5.18199 18.033 4.32456 17.41 4.46467 16.5931L5.15585 12.5632C5.21148 12.2389 5.10393 11.9079 4.86825 11.6781L1.94038 8.82416C1.34687 8.24562 1.67438 7.23765 2.4946 7.11846L6.54081 6.53051C6.86652 6.48319 7.14808 6.27862 7.29374 5.98347L9.10326 2.31699Z"
                                                fill="#F3F4F6" />
                                        </g>
                                        <defs>
                                            <clipPath id="clip0_8480_66029">
                                                <rect width="20" height="20" fill="white" />
                                            </clipPath>
                                        </defs>
                                    </svg>

                                </div>
                                <span class="pl-2 font-normal leading-7 text-gray-500 text-sm ">1624 review</span>
                            </div>

                        </div>
                        <p class="text-gray-500 text-base font-normal mb-5">
                            Introducing our vibrant Basic Yellow Tropical Printed Shirt - a celebration of style and
                            sunshine! Embrace the essence of summer wherever you go with this eye-catching piece that
                            effortlessly blends comfort and tropical flair. <a href="#"
                                class="text-indigo-600">More....</a>
                        </p>
                        <ul class="grid gap-y-4 mb-8">
                            <li class="flex items-center gap-3">
                                <svg width="26" height="26" viewBox="0 0 26 26" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <rect width="26" height="26" rx="13" fill="#4F46E5" />
                                    <path
                                        d="M7.66669 12.629L10.4289 15.3913C10.8734 15.8357 11.0956 16.0579 11.3718 16.0579C11.6479 16.0579 11.8701 15.8357 12.3146 15.3913L18.334 9.37183"
                                        stroke="white" stroke-width="1.6" stroke-linecap="round" />
                                </svg>
                                <span class="font-normal text-base text-gray-900 ">Pet Friendly</span>
                            </li>
                            <li class="flex items-center gap-3">
                                <svg width="26" height="26" viewBox="0 0 26 26" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <rect width="26" height="26" rx="13" fill="#4F46E5" />
                                    <path
                                        d="M7.66669 12.629L10.4289 15.3913C10.8734 15.8357 11.0956 16.0579 11.3718 16.0579C11.6479 16.0579 11.8701 15.8357 12.3146 15.3913L18.334 9.37183"
                                        stroke="white" stroke-width="1.6" stroke-linecap="round" />
                                </svg>
                                <span class="font-normal text-base text-gray-900 ">Garage</span>
                            </li>
                            <li class="flex items-center gap-3">
                                <svg width="26" height="26" viewBox="0 0 26 26" fill="none"
                                    xmlns="http://www.w3.org/2000/svg">
                                    <rect width="26" height="26" rx="13" fill="#4F46E5" />
                                    <path
                                        d="M7.66669 12.629L10.4289 15.3913C10.8734 15.8357 11.0956 16.0579 11.3718 16.0579C11.6479 16.0579 11.8701 15.8357 12.3146 15.3913L18.334 9.37183"
                                        stroke="white" stroke-width="1.6" stroke-linecap="round" />
                                </svg>
                                <span class="font-normal text-base text-gray-900 ">Ameneties
                                    </span>
                            </li>
                          
                        </ul>
                        <div class="w-full pb-8 border-b  border-gray-300 flex-wrap">
                            <div class="grid grid-cols-3 min-[400px]:grid-cols-5 gap-3 max-w-md">
                                <button
                                    class="bg-white text-center py-1.5 px-4 w-full font-semibold text-lg leading-8 text-gray-900 border border-gray-200 flex items-center rounded-full justify-center transition-all duration-300 hover:bg-gray-50 hover:shadow-sm hover:shadow-gray-100 hover:border-gray-300 visited:border-gray-300 visited:bg-gray-50"> <FaBath className='me-2'/> 4 </button>
                                <button
                                    class="bg-white text-center py-1.5 px-4 w-full font-semibold text-lg leading-8 text-gray-900 border border-gray-200 flex items-center rounded-full justify-center transition-all duration-300 hover:bg-gray-50 hover:shadow-sm hover:shadow-gray-100 hover:border-gray-300 visited:border-gray-300 visited:bg-gray-50"><FaBed className='me-2'/> 2</button>
                             
                                <button
                                    class="bg-white text-center py-1.5 px-4 w-full font-semibold text-lg leading-8 text-gray-900 border border-gray-200 flex items-center rounded-full justify-center transition-all duration-300 hover:bg-gray-50 hover:shadow-sm hover:shadow-gray-100 hover:border-gray-300 visited:border-gray-300 visited:bg-gray-50"><FaToilet className='me-2'/> 8</button>


                            </div>
                            <form className='border-t mt-8 pt-6  border-gray-300 '>
                              <div class="grid gap-6 mb-6 md:grid-cols-2">
                                  <div>
                                      <label for="first_name" class="block mb-2 text-sm font-medium text-gray-900 ">First name</label>
                                      <input type="text" id="first_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 " placeholder="John" required />
                                  </div>
                                  <div>
                                      <label for="last_name" class="block mb-2 text-sm font-medium text-gray-900 ">Last name</label>
                                      <input type="text" id="last_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 " placeholder="Doe" required />
                                  </div>
                                  </div>
                                  <div className='w-50'>
                                      <label for="last_name" class="block mb-2 text-sm font-medium text-gray-900 "> Tour Date </label>
                                      <input type="Date" id="last_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 " placeholder="Doe" required />
                                  </div>
                                  <button
                                  
                                  class="group py-4 mt-6 px-5 rounded-full bg-indigo-50 text-indigo-600 font-semibold text-lg w-full flex items-center justify-center gap-2 transition-all duration-500 hover:bg-indigo-100">
                                  <svg class="stroke-indigo-600 " width="22" height="22" viewBox="0 0 22 22" fill="none"
                                      xmlns="http://www.w3.org/2000/svg">
                                      <path
                                          d="M10.7394 17.875C10.7394 18.6344 10.1062 19.25 9.32511 19.25C8.54402 19.25 7.91083 18.6344 7.91083 17.875M16.3965 17.875C16.3965 18.6344 15.7633 19.25 14.9823 19.25C14.2012 19.25 13.568 18.6344 13.568 17.875M4.1394 5.5L5.46568 12.5908C5.73339 14.0221 5.86724 14.7377 6.37649 15.1605C6.88573 15.5833 7.61377 15.5833 9.06984 15.5833H15.2379C16.6941 15.5833 17.4222 15.5833 17.9314 15.1605C18.4407 14.7376 18.5745 14.0219 18.8421 12.5906L19.3564 9.84059C19.7324 7.82973 19.9203 6.8243 19.3705 6.16215C18.8207 5.5 17.7979 5.5 15.7522 5.5H4.1394ZM4.1394 5.5L3.66797 2.75"
                                          stroke="" stroke-width="1.6" stroke-linecap="round" />
                                  </svg>
                                  Pick a Tour</button>
                                  </form>
                           

                        </div>
                        <div class=" pb-8 border-b w-full border-gray-300 mt-3">
                        <p class="text-gray-900 text-lg leading-8 ont-medium mb-4">Location</p>
                            <iframe class="max-w-xs mx-auto rounded-2xl  h-64" src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d12948.259989929075!2d-0.130316525088519!3d51.50803635641335!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zNTHCsDMwJzE3LjYiTiAxMMKwMzgnNDQuMSJF!5e0!3m2!1sen!2suk!4v1640968225374!5m2!1sen!2suk" frameborder="0" allowfullscreen></iframe>
                           </div>
                           <div class=" pb-8 border-b w-full border-gray-300 mt-3">
                        <p class="text-gray-900 text-lg leading-8 ont-medium mb-2">Contact</p>
                            <div className="w-full flex flex-col items-center ">
                              <div className=''>

                              <img className='rounded-full  '  style={{width:'200px' , marginLeft:'-28px'}} src={Contact} alt="" />
                              </div>
                              
                          
                              <div  className='text-center ms-10'> 
                              <div className=' flex '>
                                <UserIcon className='w-6 mx-2'/>
                              <p className='text-gray-500 font-bold text-lg'>Agent Name</p> 
                              </div>
                              
                              <div className=' flex '>
                                <PhoneArrowDownLeftIcon className='w-6 mx-2'/>
                                <p className='text-gray-500 font-bold text-lg'>0666666666</p> 
                              </div>
                              <div className=' flex '>
                                < InboxArrowDownIcon className='w-6 mx-2'/>
                                <p className='text-gray-500 font-bold text-lg'>Agent1133@email.com</p> 
                              </div>
                              

                              </div>
                              <button
                                class="group py-4 mt-6  px-5 rounded-full bg-indigo-50 text-indigo-600 font-semibold text-lg w-full flex items-center justify-center gap-2 transition-all duration-500 hover:bg-indigo-100">
                               
                                See Profile</button>
                            </div>
                           </div>

                       
                     
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div className='bg-white'>

                    
    </div>
      
    </div>
  )
}

export default PropertyDetail
