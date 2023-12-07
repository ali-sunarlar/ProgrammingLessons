#!/usr/bin/env python3
# -*- coding: utf-8 -*-
#kutuphaneler
import numpy as np
import matplotlib.pyplot as plt
import pandas as pd

#kodlar
#veri yukleme
veri = pd.read_csv('veriler.csv')
#pd.read_csv("veriler.csv") "" cift tirnak ile cagrilabilir

boy = veri[['boy']]
print(boy)
boykilo = veri[['boy','kilo']]
print(boykilo)