package temp;

import java.util.*;

// 하드디스크를 관리하는 메모리 캐시
class MemCache {
    private static Map<String, MemCache> instanceMap = new HashMap<>(); //데이터를 저장
    private static Queue<String> memCacheQueue = new LinkedList<>(); //데이터 순서
    private static int cacheMaxSize;

    private String diskName;

    private MemCache(String diskName) {
        this.diskName = diskName;
    }

    public static MemCache getInstance(String diskName) {

        //인스턴스가 있는지 찾는다.
        //존재할 경우, 인스턴스 반환
        for (Map.Entry<String, MemCache> memCacheEntry : instanceMap.entrySet()) {
            String diskNameInMem = memCacheEntry.getKey();
            if(diskNameInMem.equals(diskName)) {
                return memCacheEntry.getValue();
            }
        }

        //없을 경우,
        //사이즈가 넘으면 제거하고 추가
        int memCacheSize = memCacheQueue.size();
        MemCache memCache = new MemCache(diskName);

        if(memCacheSize >= cacheMaxSize) {
            String pollDiskName = memCacheQueue.poll();
            memCacheQueue.add(memCache.getDiskName());

            instanceMap.remove(pollDiskName);
            instanceMap.put(memCache.diskName, memCache);

            return memCache;
        }
        //사이즈가 적으면 반환
        instanceMap.put(memCache.diskName, memCache);
        memCacheQueue.add(memCache.getDiskName());
        return memCache;
    }

    public String getDiskName() {
        return diskName;
    }
}
