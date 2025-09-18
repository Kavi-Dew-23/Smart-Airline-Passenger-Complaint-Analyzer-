from fastapi.middleware.cors import CORSMiddleware

app.add_middleware(
    CORSMiddleware,
    allow_origins=[
        "http://localhost:5000",  
        "https://smart-airline-passenger-complaint-a.vercel.app/",  
        "https://dewapura-smart-airline-passenger-complaint-analyzer.hf.space" 
    ],
    allow_credentials=True,
    allow_methods=["*"],
    allow_headers=["*"],
)
